namespace BooksShop.Core.ViewModels.Messages
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using static BooksShop.Infrastructure.Data.Constants;

    public class MessageInputModel
    {
        [Required(ErrorMessage = ErrorMessageFirstName)]
        [Display(Name = DisplayFirstName)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = ErrorMessageLastName)]
        [Display(Name = DisplayLastName)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = ErrorMessageEmail)]
        [EmailAddress]
        [Display(Name = DisplayEmail)]
        public string Email { get; set; } = null!;

        [Phone]
        public string? Phone { get; set; }

        [Required(ErrorMessage = ErrorMessageSubject)]
        [Display(Name = DisplaySubject)]

        public string Subject { get; set; }

        [Required(ErrorMessage = ErrorMessageContent)]
        [MinLength(5, ErrorMessage = MaxLengthErrorMessageContent)]
        [MaxLength(1024, ErrorMessage = MinLengthErrorMessageContent)]
        [Display(Name = DisplayContent)]

        public string Content { get; set; } = null!;

        public List<SelectListItem> SubjectList { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "Order Status", Text = "Order Status" },
            new SelectListItem { Value = "Refund Request", Text = "Refund Request" },
            new SelectListItem { Value = "Job Application", Text = "Job Application" },
            new SelectListItem { Value = "Other", Text = "Other" },
        };

        //public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
