namespace BooksShop.Core.ViewModels.Orders
{
    public class OrdersInListViewModel : OrderBaseViewModel
    {
        public IEnumerable<BookOrderViewModel> BookOrders { get; set; } =
            new List<BookOrderViewModel>();

        public int ItemsCount => BookOrders.Select(x => x.Quantity).Sum();

        public decimal BooksTotalSum => BookOrders.Select(x => x.BookTotalPrice).Sum() + ShippingFee;
    }
}
