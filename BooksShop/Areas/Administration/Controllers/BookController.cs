namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Contracts;
    using BooksShop.Core.ViewModels.Books;
    using BooksShop.Infrastructure.Data;
    using Microsoft.AspNetCore.Mvc;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookController : AdministrationController
    {
        private readonly IBookService bookService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public BookController(
            IBookService bookService,
            IWebHostEnvironment webHostEnvironment)
        {
            this.bookService = bookService;
            this.webHostEnvironment = webHostEnvironment;
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
                await this.bookService.CreateBookAsync(model, this.webHostEnvironment.WebRootPath);
                this.TempData[Constants.Message] = BookCreated;
                return this.RedirectToAction(nameof(this.All));
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, BookCreationFailed);
                this.TempData[Constants.Message] = ex.Message;
                model.Categories = await this.bookService.GetAllCategories();
                return this.View(model);
            }
        }

        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            Book book = await this.bookService.GetBookById(id);
            if (book == null)
            {
                return this.NotFound();
            }

            BookEditModel model = await this.bookService.GetBookForEdit(id);
            model.Categories = await this.bookService.GetAllCategories();
            return this.View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(BookEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                model.Categories = await this.bookService.GetAllCategories();
                return this.View(model);
            }

            try
            {
                await this.bookService.EditBookAsync(model, this.webHostEnvironment.WebRootPath);
                this.TempData[Constants.Message] = BookEdited;
                return this.RedirectToAction(nameof(this.All));
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                model.Categories = await this.bookService.GetAllCategories();
                this.TempData[Constants.Message] = ex.Message;
                return this.View(model);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.bookService.DeleteBookAsync(id, this.webHostEnvironment.WebRootPath);
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
