namespace BooksShop.Core.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookBaseModel
    {
        [Required(ErrorMessage = TitleErrorMessage)]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required(ErrorMessage = AuthorErrorMessage)]
        [StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength)]
        public string Author { get; set; }

        [Required(ErrorMessage = ISBNErrorMessage)]
        [StringLength(ISBNMaxLength, MinimumLength = ISBNMinLength)]

        public string ISBN { get; set; }

        [Required(ErrorMessage = NumOfPagesErrorMessage)]
        [Range(MinNumOfPages, MaxNumOfPages, ErrorMessage = NumOfPagesRangeErrorMessage)]

        public int NumOfPages { get; set; }

        [Required(ErrorMessage = PriceErrorMessage)]

        public decimal Price { get; set; }

        [Required]

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        [MaxLength(DescriptionMaxLength, ErrorMessage = MaxLengthDescriptionErrorMessage)]
        public string? Description { get; set; } = null;
    }
}
