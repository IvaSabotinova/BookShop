namespace BooksShop.Core.ViewModels.Books
{
    public class BookIndexViewModel
    {
        public IEnumerable<BookViewModel> Books { get; set; }

        public string Search { get; set; }
    }
}
