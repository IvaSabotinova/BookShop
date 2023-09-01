namespace BooksShop.Core.ViewModels.Books
{
    public class BookInListViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        // public string ISBN { get; set; }
        public int NumOfPages { get; set; }

        public decimal Price { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
