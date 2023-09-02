namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static BooksShop.Infrastructure.Data.Constants;

    public class Book
    {
        public int Id { get; set; }

        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [MaxLength(AuthorMaxLength)]
        public string Author { get; set; }

        [MaxLength(ISBNMaxLength)]

        public string ISBN { get; set; }

        public int NumOfPages { get; set; }

        [Column(TypeName = DecimalType)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; } = null;

        public string ImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
