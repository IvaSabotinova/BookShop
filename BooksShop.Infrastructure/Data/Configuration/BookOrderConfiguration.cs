namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BookOrderConfiguration : IEntityTypeConfiguration<BookOrder>
    {
        public void Configure(EntityTypeBuilder<BookOrder> builder)
        {
            builder.HasData(this.CreateBooksOrders());
        }

        private List<BookOrder> CreateBooksOrders()
        {
            List<BookOrder> booksOrders = new List<BookOrder>()
            {
                new BookOrder()
                {
                    OrderId = 1,
                    BookId = 15,
                    Quantity = 2,
                    UnitPrice = 65m,
                },
                new BookOrder()
                {
                    OrderId = 2,
                    BookId = 13,
                    Quantity = 1,
                    UnitPrice = 98.50m,
                },
                new BookOrder()
                {
                    OrderId = 3,
                    BookId = 14,
                    Quantity = 1,
                    UnitPrice = 68.50m,
                },
                new BookOrder()
                {
                    OrderId = 4,
                    BookId = 15,
                    Quantity = 1,
                    UnitPrice = 65m,
                },
                new BookOrder()
                {
                    OrderId = 5,
                    BookId = 27,
                    Quantity = 3,
                    UnitPrice = 35.50m,
                },
                new BookOrder()
                {
                    OrderId = 5,
                    BookId = 16,
                    Quantity = 2,
                    UnitPrice = 62,
                },
                new BookOrder()
                {
                    OrderId = 6,
                    BookId = 17,
                    Quantity = 2,
                    UnitPrice = 78m,
                },
                new BookOrder()
                {
                    OrderId = 6,
                    BookId = 18,
                    Quantity = 1,
                    UnitPrice = 69m,
                },
                new BookOrder()
                {
                    OrderId = 7,
                    BookId = 1,
                    Quantity = 10,
                    UnitPrice = 25.8m,
                },
                new BookOrder()
                {
                    OrderId = 8,
                    BookId = 5,
                    Quantity = 3,
                    UnitPrice = 75.00m,
                },
                new BookOrder()
                {
                    OrderId = 9,
                    BookId = 4,
                    Quantity = 2,
                    UnitPrice = 99.90m,
                },
                new BookOrder()
                {
                    OrderId = 10,
                    BookId = 2,
                    Quantity = 1,
                    UnitPrice = 96.40m,
                },
                new BookOrder()
                {
                    OrderId = 10,
                    BookId = 6,
                    Quantity = 1,
                    UnitPrice = 45.50m,
                },
                new BookOrder()
                {
                    OrderId = 11,
                    BookId = 3,
                    Quantity = 1,
                    UnitPrice = 38.20m,
                },
                new BookOrder()
                {
                    OrderId = 12,
                    BookId = 20,
                    Quantity = 3,
                    UnitPrice = 35.00m,
                },
                new BookOrder()
                {
                    OrderId = 13,
                    BookId = 27,
                    Quantity = 1,
                    UnitPrice = 35.50m,
                },
                new BookOrder()
                {
                    OrderId = 14,
                    BookId = 27,
                    Quantity = 3,
                    UnitPrice = 35.50m,
                },
                new BookOrder()
                {
                    OrderId = 15,
                    BookId = 18,
                    Quantity = 5,
                    UnitPrice = 69.00m,
                },
                new BookOrder()
                {
                    OrderId = 15,
                    BookId = 5,
                    Quantity = 3,
                    UnitPrice = 75.00m,
                },
                new BookOrder()
                {
                    OrderId = 16,
                    BookId = 18,
                    Quantity = 1,
                    UnitPrice = 69.00m,
                },
                new BookOrder()
                {
                    OrderId = 17,
                    BookId = 27,
                    Quantity = 6,
                    UnitPrice = 35.50m,
                },
                new BookOrder()
                {
                    OrderId = 18,
                    BookId = 17,
                    Quantity = 5,
                    UnitPrice = 78.00m,
                },
                new BookOrder()
                {
                    OrderId = 19,
                    BookId = 19,
                    Quantity = 1,
                    UnitPrice = 69.90m,
                },
                new BookOrder()
                {
                    OrderId = 20,
                    BookId = 22,
                    Quantity = 2,
                    UnitPrice = 52.90m,
                },
                new BookOrder()
                {
                    OrderId = 21,
                    BookId = 22,
                    Quantity = 7,
                    UnitPrice = 52.90m,
                },
                new BookOrder()
                {
                    OrderId = 22,
                    BookId = 27,
                    Quantity = 10,
                    UnitPrice = 35.50m,
                },
                new BookOrder()
                {
                    OrderId = 23,
                    BookId = 23,
                    Quantity = 3,
                    UnitPrice = 30.00m,
                },
                new BookOrder()
                {
                    OrderId = 24,
                    BookId = 24,
                    Quantity = 1,
                    UnitPrice = 32.50m,
                },
                new BookOrder()
                {
                    OrderId = 25,
                    BookId = 24,
                    Quantity = 1,
                    UnitPrice = 32.50m,
                },
                new BookOrder()
                {
                    OrderId = 26,
                    BookId = 25,
                    Quantity = 7,
                    UnitPrice = 79.90m,
                },
                new BookOrder()
                {
                    OrderId = 27,
                    BookId = 18,
                    Quantity = 7,
                    UnitPrice = 69.00m,
                },
                new BookOrder()
                {
                    OrderId = 28,
                    BookId = 20,
                    Quantity = 1,
                    UnitPrice = 35.00m,
                },
                new BookOrder()
                {
                    OrderId = 29,
                    BookId = 22,
                    Quantity = 1,
                    UnitPrice = 52.90m,
                },
                new BookOrder()
                {
                    OrderId = 30,
                    BookId = 13,
                    Quantity = 5,
                    UnitPrice = 98.50m,
                },
                new BookOrder()
                {
                    OrderId = 31,
                    BookId = 7,
                    Quantity = 1,
                    UnitPrice = 105.50m,
                },
            };

            return booksOrders;
        }
    }
}
