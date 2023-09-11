namespace BooksShop.Core.ViewModels.ShoppingCart
{
    public class BookBaseViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
