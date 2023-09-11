namespace BooksShop.Controllers
{
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using Microsoft.AspNetCore.Mvc;

    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
        }

        public async Task<IActionResult> Cart()
        {
            string? cookieValue = this.HttpContext.Request.Cookies["shopping_cart"];

            Dictionary<int, int> bookDictionary = await this.shoppingCartService.GetCookieInfoAsync(cookieValue);

            // if (bookDictionary != null)
            // {
            IEnumerable<BookOrderViewModel> model = await this.shoppingCartService.ShoppingCartInfo(bookDictionary);
            return this.View(model);

            // }
        }
    }
}
