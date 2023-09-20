namespace BooksShop.Core.ViewModels.Orders
{
    using BooksShop.Infrastructure.Data.Enums;

    public class OrderBaseViewModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal ShippingFee => 5;
    }
}
