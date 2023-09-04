namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole()
                {
                    Id = "ec3a92cc-8b64-4b83-bc6a-c20031faa327",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "6610b899-c6bf-4036-9831-ad602745c824",
                },
                new IdentityRole()
                {
                    Id = "b1353077-7dcd-4f94-820b-f8af8feb9690",
                    Name = "Client",
                    NormalizedName = "CLIENT",
                    ConcurrencyStamp = "b2e26a49-1cd2-47b3-ba2b-2211e7d851e6",
                });
        }
    }
}
