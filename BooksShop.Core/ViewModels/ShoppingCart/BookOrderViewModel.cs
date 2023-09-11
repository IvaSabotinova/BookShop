namespace BooksShop.Core.ViewModels.ShoppingCart
{
    public class BookOrderViewModel : BookBaseViewModel
    {
        public int Quantity { get; set; }

        public decimal TotalPrice => this.Price * this.Quantity;
    }
}
