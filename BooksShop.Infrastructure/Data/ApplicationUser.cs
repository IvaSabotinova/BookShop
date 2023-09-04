namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ApplicationUser : IdentityUser<string>
    {
        [MaxLength(MaxLengthUserFirstName)]
        public string FirstName { get; set; }

        [MaxLength(MaxLengthUserLastName)]
        public string LastName { get; set; }

        [MaxLength(MaxLengthUserAddress)]
        public string Address { get; set; }

        public DateTime RegisteredOn { get; set; }
    }
}
