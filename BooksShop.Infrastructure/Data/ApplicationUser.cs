namespace BooksShop.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using static BooksShop.Infrastructure.Data.Constants;

    public class ApplicationUser : IdentityUser<string>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Orders = new HashSet<Order>();
        }

        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }

        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        public DateTime RegisteredOn { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
