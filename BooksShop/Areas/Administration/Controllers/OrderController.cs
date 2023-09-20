namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class OrderController : AdministrationController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> All(int id = 1, int itemsPerPage = 7)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            OrdersListViewModel model = await this.orderService.GetAllOrders(id, itemsPerPage);
            return this.View(model);
        }

        [HttpGet]

        public async Task<IActionResult> Details(
            int orderId,
            PaymentStatus? paymentStatus,
            OrderStatus? orderStatus)
        {
            Order order = await this.orderService.GetOrderById(orderId);

            if (order == null)
            {
                return this.NotFound();
            }

            try
            {
                OrderDetailsViewModel model = await this.orderService.GetOrderDetails(order, paymentStatus, orderStatus);
                return this.View(model);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                this.TempData[Constants.Message] = GeneralErrorMessage;
                return this.RedirectToAction(nameof(this.All));
            }
        }
    }
}
