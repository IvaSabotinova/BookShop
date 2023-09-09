namespace BooksShop.Core.ViewModels.Messages
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using static BooksShop.Infrastructure.Data.Constants;

    public class MessageInputModel
    {
        [Required(ErrorMessage = FirstNameErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [Display(Name = DisplayFirstName)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [Display(Name = DisplayLastName)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = EmailErrorMessage)]
        [StringLength(EmailMaxLenght, MinimumLength = EmailMinLength)]
        [EmailAddress]
        [Display(Name = DisplayEmail)]
        public string Email { get; set; } = null!;

        [Phone]
        [MaxLength(PhoneNumberMaxLenght)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = SubjectErrorMessage)]
        [Display(Name = DisplaySubject)]
        [StringLength(SubjectMaxLength, MinimumLength = SubjectMinLength)]
        public string Subject { get; set; }

        [Required(ErrorMessage = ContentErrorMessage)]
        [MinLength(MessageContentMinLenght, ErrorMessage = MinLengthContentErrorMessageContent)]
        [MaxLength(MessageContentMaxLenght, ErrorMessage = MaxLengthContentErrorMessage)]
        [Display(Name = DisplayContent)]

        public string Content { get; set; } = null!;

        public List<SelectListItem> SubjectList { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "Order Status", Text = "Order Status" },
            new SelectListItem { Value = "Refund Request", Text = "Refund Request" },
            new SelectListItem { Value = "Job Application", Text = "Job Application" },
            new SelectListItem { Value = "Other", Text = "Other" },
        };
    }
}
