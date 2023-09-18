namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc;

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

        public async Task<IActionResult> Details(int orderId)
        {
            Order order = await this.orderService.GetOrderById(orderId);

            if (order == null)
            {
                return this.NotFound();
            }

            OrderDetailsViewModel model = await this.orderService.GetDetailsById(orderId);
            return this.View(model);
        }
    }
}
