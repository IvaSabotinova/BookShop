namespace BooksShop.Core.Services
{
    using BooksShop.Core.ViewModels.Books;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IBookService
    {
        Task<IEnumerable<SelectListItem>> GetAllCategories();

        Task CreateBook(BookInputModel model);

        Task<int> GetBooksCount(string? search);

        Task<BooksListViewModel> GetAll(
            int page,
            int itemsPerPage = 3,
            string? search = null,
            string? column = null,
            string? order = null);
    }
}
