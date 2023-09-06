namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
             builder.HasData(this.CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser admin = new ApplicationUser()
            {
                Id = "283073f1-cc28-485a-ab58-44f4ed128264",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                FirstName = "Iva",
                LastName = "Sabotinova",
                Address = "Izgrev block 41, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            admin.PasswordHash = hasher.HashPassword(admin, "admin123456");
            users.Add(admin);

            ApplicationUser client = new ApplicationUser()
            {
                Id = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                UserName = "client",
                NormalizedUserName = "CLIENT",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "client@gmail.com",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Pesho",
                LastName = "Martinov",
                Address = "Slaveykov block 33, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client.PasswordHash = hasher.HashPassword(client, "client123456");
            users.Add(client);

            return users;
        }
    }
}
