namespace BooksShop.Core.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookInputModel
    {
        [Required(ErrorMessage = TitleErrorMessage)]
        [MaxLength(100, ErrorMessage = MaxLengthTitleErrorMessage)]
        public string Title { get; set; }

        [Required(ErrorMessage = AuthorErrorMessage)]
        [MaxLength(255, ErrorMessage = MaxLengthAuthorErrorMessage)]
        public string Author { get; set; }

        [Required(ErrorMessage = ISBNErrorMessage)]
        [MaxLength(20, ErrorMessage = MaxLengthISBNErrorMessage)]

        public string ISBN { get; set; }

        [Required(ErrorMessage = NumOfPagesErrorMessage)]
        [Range(1, 10000, ErrorMessage = NumOfPagesRangeErrorMessage)]

        public int NumOfPages { get; set; }

        [Required(ErrorMessage = PriceErrorMessage)]

        public decimal Price { get; set; }

        [Required]

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        [MaxLength(1000, ErrorMessage = MaxLengthDescriptionErrorMessage)]
        public string? Description { get; set; } = null;

        [Required(ErrorMessage = ImageErrorMessage)]
        public IFormFile Image { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
