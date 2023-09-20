namespace BooksShop.Controllers
{
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Core.ViewModels.Books.Enums;
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
          string search,
          int page = 1,
          int itemsPerPage = 3,
          string? column = null,
          string? order = null)
        {
            if (page <= 0)
            {
                return this.NotFound();
            }

            if (string.IsNullOrEmpty(search))
            {
                return this.RedirectToAction("Index", "Home");
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

        public async Task<IActionResult> AdvancedSearch(
            int page = 1,
            int itemsPerPage = 5,
            string? search = null,
            PriceRange? priceRange = null,
            PageRange? pageRange = null,
            int? categoryId = 0)
        {
            if (page <= 0)
            {
                return this.NotFound();
            }

            BookAdvancedSearchAndPagingViewModel model = await this.bookService
                .AdvancedSearch(page, itemsPerPage, search, priceRange, pageRange, categoryId);

            return this.View(model);
        }
    }
}
