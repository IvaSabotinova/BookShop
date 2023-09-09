namespace BooksShop.Core.ViewModels.Books
{
    using BooksShop.Core.ViewModels.Books.Enums;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class BookAdvancedSearchAndPagingViewModel : PagingViewModel
    {
        public IEnumerable<BookViewModel> Books { get; set; }

        public string? Search { get; set; }

        public PriceRange? PriceRange { get; set; }

        public PageRange? PageRange { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
