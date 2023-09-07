namespace BooksShop.Core.ViewModels.Users
{
    public class UserEditModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string Address { get; set; }

        public string? Role { get; set; }
    }
}
