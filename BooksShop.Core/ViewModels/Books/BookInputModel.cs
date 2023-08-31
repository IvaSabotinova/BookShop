namespace BooksShop.Core.ViewModels.Books
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;

    public class BookInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title is required")]
        [MaxLength(100, ErrorMessage = "The Title cannot exceed 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Author is required")]
        [MaxLength(255, ErrorMessage = "The Author cannot exceed 255 characters")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The ISBN is required")]
        [MaxLength(20, ErrorMessage = "The ISBN cannot exceed 20 characters")]

        public string ISBN { get; set; }

        [Required(ErrorMessage = "The Number of Pages is required")]
        [Range(1, 10000, ErrorMessage = "The Number of Pages must be in the range from 1 to 10000")]

        public int NumOfPages { get; set; }

        [Required(ErrorMessage = "The Price is required")]

        public decimal Price { get; set; }

        [Required]

        public string Category { get; set; }

        [MaxLength(1000, ErrorMessage = "The Description cannot exceed 1000 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Image File is required")]
        public IFormFile Image { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
