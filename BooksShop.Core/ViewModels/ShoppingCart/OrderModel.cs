namespace BooksShop.Core.ViewModels.ShoppingCart
{
    using System.ComponentModel.DataAnnotations;
    using BooksShop.Infrastructure.Data.Enums;
    using static BooksShop.Infrastructure.Data.Constants;

    public class OrderModel
    {
        public IEnumerable<BookOrderViewModel> OrderedBooks { get; set; }

        public string? CookieValue { get; set; }

        public decimal Subtotal { get; set; }

        [MaxLength(AddressMaxLength)]
        public string? DeliveryAddress { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }

        public decimal ShippingFee => 5;

        public decimal Total => this.Subtotal + this.ShippingFee;
    }
}
