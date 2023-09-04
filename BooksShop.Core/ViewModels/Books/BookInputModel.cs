namespace BooksShop.Core.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using static BooksShop.Infrastructure.Data.Constants;

    public class BookInputModel : BookBaseModel
    {
        [Required(ErrorMessage = ImageErrorMessage)]
        public IFormFile Image { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
