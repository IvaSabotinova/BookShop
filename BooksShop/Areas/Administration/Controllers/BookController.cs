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

        public async Task<IActionResult> All(int id = 1, int itemsPerPage = 3)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            BooksListViewModel model = await this.bookService.GetAll(id, itemsPerPage);
            return this.View(model);
        }
    }
}
