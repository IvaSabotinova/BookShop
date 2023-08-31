namespace BooksShop.Core.ViewModels.Messages
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using static BooksShop.Infrastructure.Data.Constants;

    public class MessageInputModel
    {
        [Required(ErrorMessage = FirstNameErrorMessage)]
        [Display(Name = DisplayFirstName)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = LastNameErrorMessage)]
        [Display(Name = DisplayLastName)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = EmailErrorMessage)]
        [EmailAddress]
        [Display(Name = DisplayEmail)]
        public string Email { get; set; } = null!;

        [Phone]
        public string? Phone { get; set; }

        [Required(ErrorMessage = SubjectErrorMessage)]
        [Display(Name = DisplaySubject)]

        public string Subject { get; set; }

        [Required(ErrorMessage = ContentErrorMessage)]
        [MinLength(5, ErrorMessage = MinLengthContentErrorMessageContent)]
        [MaxLength(1024, ErrorMessage = MaxLengthContentErrorMessage)]
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
