namespace BooksShop.Infrastructure.Data.Configuration
{
    using BooksShop.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(this.CreateOrders());
        }

        private List<Order> CreateOrders()
        {
            List<Order> orders = new List<Order>()
            {
                 new Order()
                 {
                    Id = 1,
                    ApplicationUserId = "0908214c-eac6-4029-b303-8d987037c4ad",
                    OrderDate = DateTime.Now.AddDays(-21),
                    ShippingFee = 5,
                    DeliveryAddress = "Primorski Blvd 7, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Cancelled,
                    OrderStatus = OrderStatus.Cancelled,
                 },
                 new Order()
                 {
                    Id = 2,
                    ApplicationUserId = "7a09fc16-8d35-48e4-bf98-532a876423f2",
                    OrderDate = DateTime.Now.AddDays(-18),
                    ShippingFee = 5,
                    DeliveryAddress = "Vl.Varnenchik block 8, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Cancelled,
                    OrderStatus = OrderStatus.Cancelled,
                 },
                 new Order()
                 {
                    Id = 3,
                    ApplicationUserId = "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                    OrderDate = DateTime.Now.AddDays(-16),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov Quarter block 20, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order()
                 {
                    Id = 4,
                    ApplicationUserId = "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                    OrderDate = DateTime.Now.AddDays(-16),
                    ShippingFee = 5,
                    DeliveryAddress = "Vl.Varnenchik block 50, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order
                 {
                    Id = 5,
                    ApplicationUserId = "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                    OrderDate = DateTime.Now.AddDays(-13),
                    ShippingFee = 5,
                    DeliveryAddress = "Izgrev Quarter block 6, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Cancelled,
                    OrderStatus = OrderStatus.Cancelled,
                 },
                 new Order()
                 {
                    Id = 6,
                    ApplicationUserId = "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                    OrderDate = DateTime.Now.AddDays(-10),
                    ShippingFee = 5,
                    DeliveryAddress = "Izgrev Quarter block 29, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Returned,
                 },
                 new Order()
                 {
                    Id = 7,
                    ApplicationUserId = "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                    OrderDate = DateTime.Now.AddDays(-6),
                    ShippingFee = 5,
                    DeliveryAddress = "Mara Gidik street 18, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Cancelled,
                    OrderStatus = OrderStatus.Cancelled,
                 },
                 new Order()
                 {
                    Id = 8,
                    ApplicationUserId = "038e5319-0910-4cba-bf80-253a10030324",
                    OrderDate = DateTime.Now.AddDays(-6),
                    ShippingFee = 5,
                    DeliveryAddress = "Lazur Quarter block 13, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Returned,
                 },
                 new Order()
                 {
                    Id = 9,
                    ApplicationUserId = "22657eba-f41a-4bb3-986e-83ef23fedf15",
                    OrderDate = DateTime.Now.AddDays(-5),
                    ShippingFee = 5,
                    DeliveryAddress = "Vl. Varnenchik block 14, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 10,
                    ApplicationUserId = "2c2467dc-c396-46ce-af79-da3e48398f4a",
                    OrderDate = DateTime.Now.AddDays(-5),
                    ShippingFee = 5,
                    DeliveryAddress = "Vazrazhdane Quarter block 70, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 11,
                    ApplicationUserId = "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                    OrderDate = DateTime.Now.AddDays(-4),
                    ShippingFee = 5,
                    DeliveryAddress = "Izgrev Quarter block 29, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order()
                 {
                    Id = 12,
                    ApplicationUserId = "2708e501-67b2-4c5b-aacd-9a044df9de21",
                    OrderDate = DateTime.Now.AddDays(-3),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov block 31, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 13,
                    ApplicationUserId = "f18ff312-2889-46df-a392-264b865a2c72",
                    OrderDate = DateTime.Now.AddDays(-3),
                    ShippingFee = 5,
                    DeliveryAddress = "Hr. Botev Blvd 85, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Returned,
                 },
                 new Order()
                 {
                    Id = 14,
                    ApplicationUserId = "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                    OrderDate = DateTime.Now.AddDays(-3),
                    ShippingFee = 5,
                    DeliveryAddress = "Vazrazhdane Quarter block 49, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order
                 {
                    Id = 15,
                    ApplicationUserId = "0908214c-eac6-4029-b303-8d987037c4ad",
                    OrderDate = DateTime.Now.AddDays(-2),
                    ShippingFee = 5,
                    DeliveryAddress = "Primorski Blvd 7, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 16,
                    ApplicationUserId = "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                    OrderDate = DateTime.Now.AddDays(-2),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov Quarter block 68, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 17,
                    ApplicationUserId = "2708e501-67b2-4c5b-aacd-9a044df9de21",
                    OrderDate = DateTime.Now.AddDays(-2),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov block 31, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 18,
                    ApplicationUserId = "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                    OrderDate = DateTime.Now.AddHours(-36),
                    ShippingFee = 5,
                    DeliveryAddress = "Vazrazhdane Quarter block 71, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 19,
                    ApplicationUserId = "038e5319-0910-4cba-bf80-253a10030324",
                    OrderDate = DateTime.Now.AddDays(-1),
                    ShippingFee = 5,
                    DeliveryAddress = "Lazur Quarter block 13, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 20,
                    ApplicationUserId = "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                    OrderDate = DateTime.Now.AddDays(-1),
                    ShippingFee = 5,
                    DeliveryAddress = "Gladstone street block 6, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order()
                 {
                    Id = 21,
                    ApplicationUserId = "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                    OrderDate = DateTime.Now.AddDays(-1),
                    ShippingFee = 5,
                    DeliveryAddress = "Izgrev Quarter block 29, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Returned,
                 },
                 new Order()
                 {
                    Id = 22,
                    ApplicationUserId = "109044cd-44fb-470c-b7b9-2724987b08de",
                    OrderDate = DateTime.Now.AddHours(-20),
                    ShippingFee = 5,
                    DeliveryAddress = "Lazur Quarter block 80, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.Paypal,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 23,
                    ApplicationUserId = "7a09fc16-8d35-48e4-bf98-532a876423f2",
                    OrderDate = DateTime.Now.AddHours(-18),
                    ShippingFee = 5,
                    DeliveryAddress = "Vl.Varnenchik block 8, Varna 9000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order()
                 {
                    Id = 24,
                    ApplicationUserId = "b87fc486-a805-4fad-89bd-c836281ce8a0",
                    OrderDate = DateTime.Now.AddHours(-16),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov Quarter block 17, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Accepted,
                 },
                 new Order()
                 {
                    Id = 25,
                    ApplicationUserId = "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                    OrderDate = DateTime.Now.AddHours(-15),
                    ShippingFee = 5,
                    DeliveryAddress = "Gladstone street block 6, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Created,
                 },
                 new Order()
                 {
                    Id = 26,
                    ApplicationUserId = "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                    OrderDate = DateTime.Now.AddHours(-15),
                    ShippingFee = 5,
                    DeliveryAddress = "Slaveykov Quarter block 20, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order
                 {
                    Id = 27,
                    ApplicationUserId = "109044cd-44fb-470c-b7b9-2724987b08de",
                    OrderDate = DateTime.Now.AddHours(-13),
                    ShippingFee = 5,
                    DeliveryAddress = "Lazur Quarter block 80, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 28,
                    ApplicationUserId = "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                    OrderDate = DateTime.Now.AddHours(-10),
                    ShippingFee = 5,
                    DeliveryAddress = "Stefan Stambolov Blvd 8, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Cancelled,
                    OrderStatus = OrderStatus.Cancelled,
                 },
                 new Order()
                 {
                    Id = 29,
                    ApplicationUserId = "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                    OrderDate = DateTime.Now.AddHours(-10),
                    ShippingFee = 5,
                    DeliveryAddress = "Stefan Stambolov Blvd 8, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Pending,
                    OrderStatus = OrderStatus.Shipped,
                 },
                 new Order()
                 {
                    Id = 30,
                    ApplicationUserId = "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                    OrderDate = DateTime.Now.AddHours(-8),
                    ShippingFee = 5,
                    DeliveryAddress = "Hr. Boteb Blvd block 5, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CashOnDelivery,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Delivered,
                 },
                 new Order
                 {
                    Id = 31,
                    ApplicationUserId = "038e5319-0910-4cba-bf80-253a10030324",
                    OrderDate = DateTime.Now.AddHours(-5),
                    ShippingFee = 5,
                    DeliveryAddress = "Lazur Quarter block 13, Bourgas 8000, Bulgaria",
                    PaymentMethod = PaymentMethod.CreditCard,
                    PaymentStatus = PaymentStatus.Accepted,
                    OrderStatus = OrderStatus.Created,
                 },
            };
            return orders;
        }
    }
}
