namespace BooksShop.Core.ViewModels.Books
{
    public class BookIndexViewModel
    {
        public IEnumerable<BookViewModel> NewestBooks { get; set; }

        public IEnumerable<BookViewModel> TopSalesBooks { get; set; }

        public string Search { get; set; }
    }
}
