namespace BooksShop.Controllers
{
    using System.Security.Claims;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    [Authorize(Roles = ClientRoleName)]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> All()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            try
            {
                IEnumerable<OrdersInListViewModel> model = await this.orderService.GetUserOrders(userId);
                return this.View(model);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                this.TempData[Constants.Message] = GeneralErrorMessage;
                return this.RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Details(int orderId)
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            try
            {
                UserOrderDetailsViewModel model = await this.orderService.GetUserOrderDetails(orderId, userId);

                return this.View(model);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                this.TempData[Constants.Message] = ex.Message;
                return this.RedirectToAction(nameof(this.All));
            }
        }
    }
}
