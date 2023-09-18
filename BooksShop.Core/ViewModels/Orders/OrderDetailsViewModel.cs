namespace BooksShop.Core.ViewModels.Orders
{
    public class OrderDetailsViewModel : OrderBaseViewModel
    {
        public string DeliveryAddress { get; set; }

        public string ApplicationUserId { get; set; }

        public string ApplicationUserFullName { get; set; }

        public string ApplicationUserEmail { get; set; }

        public string ApplicationUserPhoneNumber { get; set; }

        public string ApplicationUserAddress { get; set; }

        public DateTime ApplicationUserRegisteredOn { get; set; }

        public IEnumerable<BookInOrderDetailsViewModel> BookOrders { get; set; } =
            Enumerable.Empty<BookInOrderDetailsViewModel>();

        public decimal Subtotal => this.BookOrders.Select(x => x.BookTotalPrice).Sum();
    }
}
