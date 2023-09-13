namespace BooksShop.Controllers
{
    using System;
    using System.Security.Claims;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.ShoppingCart;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCartService;
        private readonly UserManager<ApplicationUser> userManager;

        public ShoppingCartController(
            IShoppingCartService shoppingCartService,
            UserManager<ApplicationUser> userManager)
        {
            this.shoppingCartService = shoppingCartService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Cart(
            string? act,
            int bookId,
            string? deliveryAddress,
            PaymentMethod? paymentMethod)
        {
            string cookieValue = this.HttpContext.Request.Cookies[Shopping_Cart] ?? string.Empty;

            string? userName = this.User.Identity?.Name;
            if (userName != null)
            {
                ApplicationUser currentUser = await this.userManager.FindByNameAsync(userName);
                deliveryAddress = currentUser.Address;
            }

            OrderModel model = await this.shoppingCartService
                .ShoppingCartInfo(cookieValue, act, bookId, deliveryAddress, paymentMethod);

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

        [HttpPost]

        public async Task<IActionResult> Cart (OrderModel model)
        {
            if (this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string? userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            await this.shoppingCartService.CreateOrder(model, userId);

            return this.View();
        }
    }
}
