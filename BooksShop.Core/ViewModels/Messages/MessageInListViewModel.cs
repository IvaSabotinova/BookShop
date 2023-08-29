namespace BooksShop.Core.ViewModels.Messages
{
    public class MessageInListViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        public string Subject { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
