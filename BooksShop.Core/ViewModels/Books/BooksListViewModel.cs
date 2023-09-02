namespace BooksShop.Core.ViewModels.Books
{
    public class BooksListViewModel : PagingViewModel
    {
        public IEnumerable<BookInListViewModel> Books { get; set; }

        public string? Search { get; set; }

        public string? Column { get; set; }

        public string? Order { get; set; }
    }
}
