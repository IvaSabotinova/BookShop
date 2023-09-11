namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.ShoppingCart;

    public interface IShoppingCartService
    {
        Task<Dictionary<int, int>> GetCookieInfoAsync(string? cookieValue);

        Task<IEnumerable<BookOrderViewModel>> ShoppingCartInfo(Dictionary<int, int> cookieValues);
    }
}
