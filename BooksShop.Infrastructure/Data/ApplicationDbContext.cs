namespace BooksShop.Data
{
    using BooksShop.Infrastructure.Data;
    using BooksShop.Infrastructure.Data.Configuration;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.Entity<IdentityUserRole<string>>()
                .HasData(// admin
                new IdentityUserRole<string>
                {
                    UserId = "283073f1-cc28-485a-ab58-44f4ed128264",
                    RoleId = "ec3a92cc-8b64-4b83-bc6a-c20031faa327",
                }, // client
                new IdentityUserRole<string>
                {
                    UserId = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                    RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
                });
            base.OnModelCreating(builder);
        }
    }
}