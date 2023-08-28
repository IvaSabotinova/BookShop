using BooksShop.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BooksShop.Core.ViewModels
{
    public class MessageInputModel
    {
        //public int Id { get; set; }

        [Required(ErrorMessage = "The First Name is required.")]
        [Display(Name = "First Name*")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The Last Name is required.")]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "The Email is required.")]
        [EmailAddress]
        [Display(Name = "Email*")]
        public string Email { get; set; } = null!;

        [Phone]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "The Subject is required.")]
        [Display(Name = "Subject*")]

        public string Subject { get; set; }

        [Required(ErrorMessage = "The Message is required.")]
        [MinLength(5, ErrorMessage = "The Message should be at least 5 characters")]
        [MaxLength(1024, ErrorMessage = "The Message should be at less than 1024 characters")]
        [Display(Name = "Message*")]

        public string Content { get; set; } = null!;

        public List<SelectListItem> SubjectList { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "Order Status", Text = "Order Status" },
            new SelectListItem { Value = "Refund Request", Text = "Refund Request" },
            new SelectListItem { Value = "Job Application", Text = "Job Application" },
            new SelectListItem { Value = "Other", Text = "Other" },

        };

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
