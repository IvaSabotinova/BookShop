namespace BooksShop.Core.ViewModels.Orders
{
    public class UserOrderDetailsViewModel : OrderBaseViewModel
    {
        public string DeliveryAddress { get; set; }

        public IEnumerable<BookInOrderDetailsViewModel> BookOrders { get; set; } =
            Enumerable.Empty<BookInOrderDetailsViewModel>();

        public decimal Subtotal => BookOrders.Select(x => x.BookTotalPrice).Sum();
    }
}
