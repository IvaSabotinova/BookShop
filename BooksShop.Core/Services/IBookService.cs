namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Books;

    public interface IBookService
    {
        Task<int> GetBooksCount(string? search);

        Task<BooksListViewModel> GetAll(int page, int itemsPerPage = 3, string? search = null);
    }
}
