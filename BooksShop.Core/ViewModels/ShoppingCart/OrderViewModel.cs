namespace BooksShop.Core.ViewModels.ShoppingCart
{
    public class OrderViewModel
    {
        public IEnumerable<BookOrderViewModel> OrderedBooks { get; set; }

        public string? CookieValue { get; set; }
    }
}
