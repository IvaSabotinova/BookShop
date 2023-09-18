namespace BooksShop.Core.ViewModels.Orders
{
    public class BookOrderViewModel
    {
        public int BookId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal BookTotalPrice => this.Quantity * this.UnitPrice;
    }
}
