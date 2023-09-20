namespace BooksShop.Core.Services
{
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;
    using static BooksShop.Infrastructure.Data.Constants;

    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepo;
        private readonly IMapper mapper;

        public OrderService(
            IRepository<Order> orderRepo,
            IMapper mapper)
        {
            this.orderRepo = orderRepo;
            this.mapper = mapper;
        }

        public async Task<int> GetOrdersCount()
        => await this.orderRepo.AllAsNoTracking().CountAsync();

        public async Task<OrdersListViewModel> GetAllOrders(int page, int itemsPerPage)
        {
            List<OrdersInListViewModel> model = await this.orderRepo.AllAsNoTracking()
                .OrderByDescending(x => x.OrderDate)
                .ProjectTo<OrdersInListViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();

            return new OrdersListViewModel()
            {
                CurrentPageNumber = page,
                ItemsPerPage = itemsPerPage,
                AllItemsCount = await this.GetOrdersCount(),
                Orders = model,
            };
        }

        public async Task<Order> GetOrderById(int id)
        => await this.orderRepo.All()
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<OrderDetailsViewModel> GetOrderDetails(
            Order order,
            PaymentStatus? paymentStatus,
            OrderStatus? orderStatus)
        {
            if (paymentStatus != null)
            {
                order.PaymentStatus = (PaymentStatus)paymentStatus;
                await this.orderRepo.SaveChangesAsync();
            }

            if (orderStatus != null)
            {
                order.OrderStatus = (OrderStatus)orderStatus;
                await this.orderRepo.SaveChangesAsync();
            }

            return await this.orderRepo.AllAsNoTracking()
              .Where(x => x.Id == order.Id)
              .ProjectTo<OrderDetailsViewModel>(this.mapper.ConfigurationProvider)
              .FirstAsync();
        }

        public async Task<IEnumerable<OrdersInListViewModel>> GetUserOrders(string userId)
        => await this.orderRepo.AllAsNoTracking()
                .Where(x => x.ApplicationUserId == userId)
                .OrderByDescending(x => x.OrderDate)
                .ProjectTo<OrdersInListViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<UserOrderDetailsViewModel> GetUserOrderDetails(int orderId, string userId)
        {
            Order order = await this.GetOrderById(orderId);

            if (order == null)
            {
                throw new NullReferenceException(OrderNotFound);
            }

            if (order.ApplicationUserId != userId)
            {
                throw new InvalidOperationException(OrderNotBelongToUser);
            }

            return await this.orderRepo.AllAsNoTracking()
                .Where(x => x.Id == orderId)
                .ProjectTo<UserOrderDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
        }
    }
}
