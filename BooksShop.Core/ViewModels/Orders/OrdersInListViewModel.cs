namespace BooksShop.Core.ViewModels.Orders
{
    public class OrdersInListViewModel : OrderBaseViewModel
    {
        public IEnumerable<BookOrderViewModel> BookOrders { get; set; } =
            new List<BookOrderViewModel>();

        public int ItemsCount => this.BookOrders.Select(x => x.Quantity).Sum();

        public decimal BooksTotalSum => this.BookOrders.Select(x => x.BookTotalPrice).Sum() + this.ShippingFee;
    }
}
