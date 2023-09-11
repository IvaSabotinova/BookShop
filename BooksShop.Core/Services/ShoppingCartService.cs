namespace BooksShop.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<Book> booksRepo;
        private readonly IMapper mapper;

        public ShoppingCartService(
            IRepository<Book> booksRepo,
            IMapper mapper)
        {
            this.booksRepo = booksRepo;
            this.mapper = mapper;
        }

        public async Task<Dictionary<int, int>> GetCookieInfoAsync(string? cookieValue)
        {
           Dictionary<int, int> bookDictionary = new Dictionary<int, int>();

           if (cookieValue != null)
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

        public async Task<IEnumerable<BookOrderViewModel>> ShoppingCartInfo(Dictionary<int, int> cookieValues)
        {
            List<BookOrderViewModel> shoppingCartBooks = new List<BookOrderViewModel>();
            foreach (KeyValuePair<int, int> book in cookieValues)
            {
                BookOrderViewModel model = await this.booksRepo.AllAsNoTracking()
                    .Where(x => x.Id == book.Key)
                    .ProjectTo<BookOrderViewModel>(this.mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync();

                if (model == null)
                {
                    throw new InvalidOperationException(BookNotAvailable);
                }

                model.Quantity = book.Value;
                shoppingCartBooks.Add(model);
            }
            return shoppingCartBooks;
        }
    }
}
