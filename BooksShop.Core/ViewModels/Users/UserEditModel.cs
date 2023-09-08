namespace BooksShop.Core.ViewModels.Users
{
    using System.ComponentModel.DataAnnotations;
    using static BooksShop.Infrastructure.Data.Constants;

    public class UserEditModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = FirstNameErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]

        public string FirstName { get; set; }

        [Required(ErrorMessage = LastNameErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; }

        [Required(ErrorMessage = EmailErrorMessage)]
        [EmailAddress]
        [StringLength(EmailMaxLenght, MinimumLength = EmailMinLength)]
        public string Email { get; set; }

        [Phone]
        [StringLength(PhoneNumberMaxLenght)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = AddressErrorMessage)]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string Address { get; set; }

        public string? Role { get; set; }
    }
}
