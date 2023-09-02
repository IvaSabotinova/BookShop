namespace BooksShop.Areas.Administration.Controllers
{
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels.Books;
    using Microsoft.AspNetCore.Mvc;

    public class BookController : AdministrationController
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
    }
}
