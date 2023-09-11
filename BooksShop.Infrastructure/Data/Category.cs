namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using static BooksShop.Infrastructure.Data.Constants;

    public class Category
    {
        public Category()
        {
            this.Books = new HashSet<Book>();
        }

        public int Id { get; set; }

        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
