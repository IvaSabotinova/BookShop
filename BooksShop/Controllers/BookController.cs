namespace BooksShop.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc;

    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]

        public async Task<IActionResult> All(
               int page = 1,
               int itemsPerPage = 3,
               string? search = null,
               string? column = null,
               string? order = null)
        {
            if (page <= 0)
            {
                return this.NotFound();
            }

            BooksListViewModel model = await this.bookService.GetAll(page, itemsPerPage, search, column, order);
            return this.View(model);
        }

        [HttpGet]

        public async Task<IActionResult> Details(int id)
        {
           Book book = await this.bookService.GetBookById(id);
           if (book == null)
           {
                return this.NotFound();
           }

           BookDetailsViewModel model = await this.bookService.GetDetailsById(id);
           return this.View(model);
        }

        [HttpGet]

        public async Task<IActionResult> AdvancedSearch()
        {
            BookAdvancedSearchAndPagingViewModel model = new BookAdvancedSearchAndPagingViewModel()
            {
                Categories = await this.bookService.GetAllCategories(),
            };

            return this.View(model);
        }
    }
}
