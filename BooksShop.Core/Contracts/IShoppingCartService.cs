namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.ShoppingCart;

    public interface IShoppingCartService
    {
        Task<OrderViewModel> ShoppingCartInfo(string cookieValue, string? action, int bookId);
    }
}
