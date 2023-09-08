namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IBookService
    {
        Task<int> GetBooksCount(string? search);

        Task<BooksListViewModel> GetAll(
            int page,
            int itemsPerPage = 3,
            string? search = null,
            string? column = null,
            string? order = null);

        Task<IEnumerable<SelectListItem>> GetAllCategories();

        Task CreateBookAsync(BookInputModel model, string webRootPath);

        Task<Book> GetBookById(int id);

        Task<BookEditModel> GetBookForEdit(int id);

        Task EditBookAsync(BookEditModel model, string webRootPath);

        Task DeleteBookAsync(int id, string webRootPath);

        Task<IEnumerable<BookViewModel>> GetFourNewestBooks();
    }
}
