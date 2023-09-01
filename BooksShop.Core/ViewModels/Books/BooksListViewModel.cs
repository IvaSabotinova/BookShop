namespace BooksShop.Core.ViewModels.Books
{
    public class BooksListViewModel : PagingViewModel
    {
        public IEnumerable<BookInListViewModel> Books { get; set; }
    }
}
