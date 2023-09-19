namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;

    public interface IOrderService
    {
        Task<int> GetOrdersCount();

        Task<OrdersListViewModel> GetAllOrders(int page, int itemsPerPage);

        Task<Order> GetOrderById(int id);

        Task<OrderDetailsViewModel> GetOrderDetails(
            Order order,
            PaymentStatus? paymentStatus,
            OrderStatus? orderStatus);
    }
}
