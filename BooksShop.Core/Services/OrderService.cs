namespace BooksShop.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Orders;
    using BooksShop.Infrastructure.Common;
    using BooksShop.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

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
        => await this.orderRepo.AllAsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

        public async Task<OrderDetailsViewModel> GetDetailsById(int orderId)
        => await this.orderRepo.AllAsNoTracking()
                .Where(x => x.Id == orderId)
                .ProjectTo<OrderDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
    }
}
