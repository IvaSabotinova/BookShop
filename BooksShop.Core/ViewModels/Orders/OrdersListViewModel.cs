namespace BooksShop.Core.ViewModels.Orders
{
    public class OrdersListViewModel : PagingViewModel
    {
        public IEnumerable<OrdersInListViewModel> Orders { get; set; } =
            Enumerable.Empty<OrdersInListViewModel>();
    }
}
