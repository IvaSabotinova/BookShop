namespace BooksShop.Core.Contracts
{
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Core.ViewModels.Books.Enums;
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

        Task<BookDetailsViewModel> GetDetailsById(int id);

        Task<int> AdvancedSearchBooksCount(
            string? search,
            PriceRange? priceRange,
            PageRange? pageRange,
            int? categoryId);

        Task<BookAdvancedSearchAndPagingViewModel> AdvancedSearch(
            int page,
            int itemsPerPage,
            string? search,
            PriceRange? priceRange,
            PageRange? pageRange,
            int? categoryId);
    }
}
