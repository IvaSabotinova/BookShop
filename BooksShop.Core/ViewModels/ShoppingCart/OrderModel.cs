namespace BooksShop.Core.ViewModels.ShoppingCart
{
    using BooksShop.Infrastructure.Data.Enums;

    public class OrderModel
    {
        public IEnumerable<BookOrderViewModel> OrderedBooks { get; set; } = Enumerable.Empty<BookOrderViewModel>();

        public string CookieValue { get; set; }

        public decimal Subtotal { get; set; }

        public string? DeliveryAddress { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }

        public decimal ShippingFee => 5;

        public decimal Total => this.Subtotal + this.ShippingFee;
    }
}
