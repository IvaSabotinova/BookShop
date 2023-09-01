namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Books;

    public interface IBookService
    {
        Task<int> GetBooksCount();

        Task<BooksListViewModel> GetAll(int page, int itemsPerPage = 2);
    }
}
