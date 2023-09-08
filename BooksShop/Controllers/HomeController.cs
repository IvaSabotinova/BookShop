namespace BooksShop.Controllers
{
    using System.Diagnostics;
    using BooksShop.Core.Services;
    using BooksShop.Core.ViewModels;
    using BooksShop.Core.ViewModels.Books;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IBookService bookService;

        public HomeController(
            ILogger<HomeController> logger,
            IBookService bookService)
        {
            this.logger = logger;
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<BookViewModel> model = await this.bookService.GetFourNewestBooks();
            return this.View(model);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}