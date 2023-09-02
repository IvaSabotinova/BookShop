namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Books;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookController : AdministrationController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            BookInputModel model = new BookInputModel()
            {
                Categories = await this.bookService.GetAllCategories(),
            };
            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Create(BookInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.Categories = await this.bookService.GetAllCategories();
                return this.View(model);
            }

            try
            {
                await this.bookService.CreateBook(model);
                this.TempData[Message] = BookCreated;
                return this.RedirectToAction(nameof(this.All));
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                this.TempData[Message] = BookCreationFailed;
                return this.View(model);
            }
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
    }
}
