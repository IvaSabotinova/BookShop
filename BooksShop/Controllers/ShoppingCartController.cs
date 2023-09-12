namespace BooksShop.Controllers
{
    using System;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
        }

        public async Task<IActionResult> Cart(string? act, int bookId)
        {
            string cookieValue = this.HttpContext.Request.Cookies[Shopping_Cart] ?? string.Empty;

            OrderViewModel model = await this.shoppingCartService.ShoppingCartInfo(cookieValue, act, bookId);

            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(365);
            cookieOptions.Path = "/";

            this.Response.Cookies.Append(Shopping_Cart, model.CookieValue, cookieOptions);

            if (act != null && bookId != 0 && model.CookieValue != cookieValue)
            {
                // Redirect to the same page:
                //   - to remove the query string from the url
                //   - to set the shopping cart size using the updated cookie
                this.Response.Redirect(this.Request.Path.ToString());
            }

            return this.View(model);
        }
    }
}
