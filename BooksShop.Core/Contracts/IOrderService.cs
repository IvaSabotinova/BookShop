namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Data;

    public interface IOrderService
    {
        Task<int> GetOrdersCount();

        Task<OrdersListViewModel> GetAllOrders(int page, int itemsPerPage);

        Task<Order> GetOrderById(int id);

        Task<OrderDetailsViewModel> GetDetailsById(int orderId);
    }
}
