namespace BooksShop.Core.ViewModels.Books
{
    using Microsoft.AspNetCore.Http;

    public class BookEditModel : BookBaseModel
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile? ImageFile { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
