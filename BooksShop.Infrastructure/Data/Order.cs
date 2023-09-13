namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using static BooksShop.Infrastructure.Data.Constants;

    public class Order
    {
        public Order()
        {
            this.BookOrders = new HashSet<BookOrder>();
        }

        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = DecimalType)]
        public decimal ShippingFee { get; set; }

        [MaxLength(AddressMaxLength)]
        public string DeliveryAddress { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public virtual ICollection<BookOrder> BookOrders { get; set; }
    }
}