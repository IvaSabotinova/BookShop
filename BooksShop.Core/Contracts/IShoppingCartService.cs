namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.ShoppingCart;
    using BooksShop.Infrastructure.Data.Enums;

    public interface IShoppingCartService
    {
        Task<OrderModel> ShoppingCartInfo(
            string cookieValue,
            string? action,
            int bookId,
            string? deliveryAddress,
            PaymentMethod? paymentMethod);

        Task CreateOrder(OrderModel model, string userId);
    }
}
