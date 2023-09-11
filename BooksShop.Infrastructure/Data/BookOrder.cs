namespace BooksShop.Infrastructure.Data
{
    public class BookOrder
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice => this.Quantity * this.Book.Price;
    }
}
