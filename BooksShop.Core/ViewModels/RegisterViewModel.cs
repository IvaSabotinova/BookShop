namespace BooksShop.Core.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    using static BooksShop.Infrastructure.Data.Constants;

    public class RegisterViewModel
    {
        [Required(ErrorMessage = UserNameErrorMessage)]
        [StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = FirstNameErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = LastNameErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string Lastname { get; set; }

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

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
