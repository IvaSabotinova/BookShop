namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Economics",
                },

                new Category()
                {
                    Id = 2,
                    Name = "Technology",
                },

                new Category()
                {
                    Id = 3,
                    Name = "Mathematics",
                },
                new Category()
                {
                    Id = 4,
                    Name = "Medicine",
                },
                new Category()
                {
                    Id = 5,
                    Name = "History",
                },
                new Category()
                {
                    Id = 6,
                    Name = "Other",
                },
            };

            return categories;
        }
    }
}
