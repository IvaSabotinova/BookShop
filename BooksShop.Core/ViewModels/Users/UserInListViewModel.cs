namespace BooksShop.Core.ViewModels.Users
{
    public class UserInListViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string? Role { get; set; }

        public DateTime RegisteredOn { get; set; }
    }
}