namespace BooksShop.Core.ViewModels.Books
{
    public class BookDetailsViewModel : BookViewModel
    {
        public string ISBN { get; set; }

        public string? Description { get; set; }
    }
}
