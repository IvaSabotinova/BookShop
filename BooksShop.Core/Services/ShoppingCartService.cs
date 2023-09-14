namespace BooksShop.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<Book> booksRepo;
        private readonly IRepository<Order> ordersRepo;
        private readonly IRepository<BookOrder> bookOrderRepo;
        private readonly IMapper mapper;

        public ShoppingCartService(
            IRepository<Book> booksRepo,
            IRepository<Order> ordersRepo,
            IRepository<BookOrder> bookOrderRepo,
            IMapper mapper)
        {
            this.booksRepo = booksRepo;
            this.ordersRepo = ordersRepo;
            this.bookOrderRepo = bookOrderRepo;
            this.mapper = mapper;
        }

        private Dictionary<int, int> GetCookieInfo(string cookieValue)
        {
           Dictionary<int, int> bookDictionary = new Dictionary<int, int>();

           if (!string.IsNullOrEmpty(cookieValue))
           {
                string[] bookIdsArray = cookieValue.Split("-");
                for (int i = 0; i < bookIdsArray.Length; i++)
                {
                    int bookId = int.Parse(bookIdsArray[i]);
                    if (!bookDictionary.ContainsKey(bookId))
                    {
                        bookDictionary.Add(bookId, 0);
                    }

                    bookDictionary[bookId]++;
                }
           }

           return bookDictionary;
        }

        public async Task<OrderModel> ShoppingCartInfo(
            string cookieValue,
            string? action,
            int bookId,
            string? deliveryAddress,
            PaymentMethod? paymentMethod)
        {
            Dictionary<int, int> bookDictionary = this.GetCookieInfo(cookieValue);

            if (action != null && bookId != 0 && bookDictionary.ContainsKey(bookId))
            {
                if (action == "add")
                {
                    bookDictionary[bookId]++;
                }
                else if (action == "subtract")
                {
                    if (bookDictionary[bookId] > 1)
                    {
                        bookDictionary[bookId]--;
                    }
                }
                else if (action == "delete")
                {
                    bookDictionary.Remove(bookId);
                }

                string newCookieValue = string.Empty;
                foreach (KeyValuePair<int, int> item in bookDictionary)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        if (string.IsNullOrEmpty(newCookieValue))
                        {
                            newCookieValue += item.Key;
                        }
                        else
                        {
                            newCookieValue += $"-{item.Key}";
                        }
                    }
                }

                cookieValue = newCookieValue;
            }

            List<BookOrderViewModel> shoppingCartBooks = new List<BookOrderViewModel>();
            decimal subTotal = 0;
            foreach (KeyValuePair<int, int> book in bookDictionary)
            {
                BookOrderViewModel model = await this.booksRepo.AllAsNoTracking()
                    .Where(x => x.Id == book.Key)
                    .ProjectTo<BookOrderViewModel>(this.mapper.ConfigurationProvider)
                    .FirstAsync();

                model.Quantity = book.Value;
                subTotal += model.TotalPrice;
                shoppingCartBooks.Add(model);
            }

            return new OrderModel()
            {
                OrderedBooks = shoppingCartBooks,
                CookieValue = cookieValue,
                Subtotal = subTotal,
                DeliveryAddress = deliveryAddress,
                PaymentMethod = paymentMethod,
            };
        }

        public async Task CreateOrder(OrderModel model, string userId)
        {
            Dictionary<int, int> bookDictionary = this.GetCookieInfo(model.CookieValue);

            if (bookDictionary.Count > 0)
            {
                Order newOrder = this.mapper.Map<Order>(model);
                newOrder.ApplicationUserId = userId;
                await this.ordersRepo.AddAsync(newOrder);
                await this.ordersRepo.SaveChangesAsync();

                foreach (KeyValuePair<int, int> bookKVP in bookDictionary)
                {
                    Book book = await this.booksRepo.AllAsNoTracking()
                        .Where(x => x.Id == bookKVP.Key)
                        .FirstOrDefaultAsync();

                    if (book == null)
                    {
                        throw new NullReferenceException();
                    }

                    newOrder.BookOrders.Add(new BookOrder
                    {
                        BookId = bookKVP.Key,
                        OrderId = newOrder.Id,
                        Quantity = bookKVP.Value,
                        UnitPrice = book.Price,
                    });
                }

                await this.bookOrderRepo.SaveChangesAsync();
            }
        }
    }
}
