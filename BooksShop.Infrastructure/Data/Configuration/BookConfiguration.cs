namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(this.CreateBooks());
        }

        private List<Book> CreateBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title = "The economy today",
                    Author = "Bradley R. Schiller",
                    ISBN = "007100940X",
                    NumOfPages = 969,
                    Price = 25.8m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/90e0e436-1c66-41ad-88e6-e1a153404144.jpg",
                },
                new Book
                {
                    Id = 2,
                    Title = "Principles of political economy",
                    Author = "John Stuart Mill",
                    ISBN = "OL25914464M",
                    NumOfPages = 1013,
                    Price = 96.4m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/73174e87-d6b4-4604-9712-7330ab87ed72.jpg",
                },
                new Book
                {
                    Id = 3,
                    Title = "The social cancer",
                    Author = "Jose Rizal",
                    ISBN = "OL14042495M",
                    NumOfPages = 502,
                    Price = 38.2m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/b8422c70-aebe-4333-8908-0a59b53e9ab3.jpg",
                },
                new Book
                {
                    Id = 4,
                    Title = "Computer networks",
                    Author = "Andrew S. Tanenbaum",
                    ISBN = "013162959X",
                    NumOfPages = 658,
                    Price = 99.9m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/0355b9fb-bf1b-4ae5-a3b9-a88ea551f1b5.jpg",
                },
                new Book
                {
                    Id = 5,
                    Title = "Computer concepts",
                    Author = "June Jamrich Parsons and Dan Oja",
                    ISBN = "0760034397",
                    NumOfPages = 313,
                    Price = 75.0m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/e538ff43-dded-46c1-b7e9-f33cd2096314.jpg",
                },
                new Book
                {
                    Id = 6,
                    Title = "Introducing Computers",
                    Author = "Robert H. Blissmer",
                    ISBN = "0471617830",
                    NumOfPages = 445,
                    Price = 45.5m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/e5089e94-d32f-43f0-9c85-25b5ecdfcd2e.jpg",
                },
                new Book
                {
                    Id = 7,
                    Title = "Elementary statistics",
                    Author = "Mario F. Triola",
                    ISBN = "0805393277",
                    NumOfPages = 581,
                    Price = 105.5m,
                    CategoryId = 3,
                    Description = "ToDo",
                    ImageUrl = "/images/books/04fe7e81-299e-4b26-b1fd-0e1a3149c9da.jpg",
                },
                new Book
                {
                    Id = 8,
                    Title = "Calculus",
                    Author = "Howard Anton",
                    ISBN = "0471153060",
                    NumOfPages = 1130,
                    Price = 80.0m,
                    CategoryId = 3,
                    Description = "ToDo",
                    ImageUrl = "/images/books/005f0140-65ad-4b24-8f05-b2d45f274f49.jpg",
                },
                new Book
                {
                    Id = 9,
                    Title = "Calculus made easy",
                    Author = "Silvanus Phillips Thompson",
                    ISBN = "0312114109",
                    NumOfPages = 250,
                    Price = 75.5m,
                    CategoryId = 3,
                    Description = "ToDo",
                    ImageUrl = "/images/books/8b457390-2df6-4f02-9a0b-6b3fe4890d85.jpg",
                },
                new Book
                {
                    Id = 10,
                    Title = "Molecularizing biology and medicine",
                    Author = "Soraya de Chadarevian and Harmke Kamminga",
                    ISBN = "9057022931",
                    NumOfPages = 304,
                    Price = 99.0m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/aa23bf8b-685c-430d-a256-7b684dd1cb90.jpg",
                },
                new Book
                {
                    Id = 11,
                    Title = "The price of health",
                    Author = "James A. Gillespie",
                    ISBN = "0521381835",
                    NumOfPages = 358,
                    Price = 85.0m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/27486390-9981-468b-93ad-c4cb1c8087ab.jpg",
                },
                new Book
                {
                    Id = 12,
                    Title = "Creative malady",
                    Author = "Pickering, George White Sir",
                    ISBN = "019519800X",
                    NumOfPages = 327,
                    Price = 60.0m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/3faa928e-f41d-4710-a469-b8b357eef1ba.jpg",
                },
                new Book
                {
                    Id = 13,
                    Title = "Economics",
                    Author = "Richard G. Lipsey",
                    ISBN = "0060440163",
                    NumOfPages = 927,
                    Price = 98.5m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/fcc69c01-79fd-45b8-82cc-d7011b5493bc.jpg",
                },
                new Book
                {
                    Id = 14,
                    Title = "The wealth of nations",
                    Author = "Adam Smith and Andrew Skinner",
                    ISBN = "067940564X",
                    NumOfPages = 620,
                    Price = 68.5m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/b449a8b1-84f1-44dd-8c6d-e965b6efa90b.jpg",
                },
                new Book
                {
                    Id = 15,
                    Title = "The human condition",
                    Author = "Hannah Arendt",
                    ISBN = "0226025926",
                    NumOfPages = 365,
                    Price = 65.0m,
                    CategoryId = 1,
                    Description = "ToDo",
                    ImageUrl = "/images/books/3f3d222a-2401-437c-81b0-7db157cef7af.jpg",
                },
                new Book
                {
                    Id = 16,
                    Title = "The Interactive Computing",
                    Author = "Kenneth C. Laudon",
                    ISBN = "0072472618",
                    NumOfPages = 632,
                    Price = 62.0m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/3f569900-cc2e-4f9d-ac96-54cddcd7e4e6.jpg",
                },
                new Book
                {
                    Id = 17,
                    Title = "Computers",
                    Author = "Larry E. Long",
                    ISBN = "013156241X",
                    NumOfPages = 677,
                    Price = 78.0m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/22ec6be5-99cc-4e1b-91b8-0459f964cfdf.jpg",
                },
                new Book
                {
                    Id = 18,
                    Title = "Advances in Computers",
                    Author = "Marshall C. Yovits",
                    ISBN = "012012114X",
                    NumOfPages = 299,
                    Price = 69.0m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/27cd64b2-01d7-4d33-bf31-ba2d9f5ef27a.jpg",
                },
                new Book
                {
                    Id = 19,
                    Title = "Blood & bone",
                    Author = "Angela Belli and John L. Coulehan",
                    ISBN = "0877456372",
                    NumOfPages = 160,
                    Price = 69.9m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/e194f5d1-1914-4ab7-ba69-f2c24cd46e03.jpg",
                },
                new Book
                {
                    Id = 20,
                    Title = "Chinese medical modernization",
                    Author = "AnElissa Lucas",
                    ISBN = "0030594545",
                    NumOfPages = 188,
                    Price = 35.0m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/6dff32cc-dcbc-425a-8406-6463b36678df.jpg",
                },
                new Book
                {
                    Id = 21,
                    Title = "The doctor stories",
                    Author = "Richard Selzer",
                    ISBN = "0312186878",
                    NumOfPages = 389,
                    Price = 40.0m,
                    CategoryId = 4,
                    Description = "ToDo",
                    ImageUrl = "/images/books/3cc142ee-2ac0-4cee-8a63-d88d271d0c86.jpg",
                },
                new Book
                {
                    Id = 22,
                    Title = "The last physician",
                    Author = "Elliott, Carl and John D. Lantos",
                    ISBN = "0822323362",
                    NumOfPages = 167,
                    Price = 52.9m,
                    CategoryId = 5,
                    Description = "ToDo",
                    ImageUrl = "/images/books/3c0e44e3-4cb5-4c12-845e-5179e4b82717.jpg",
                },
                new Book
                {
                    Id = 23,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    ISBN = "0060120355",
                    NumOfPages = 311,
                    Price = 30.0m,
                    CategoryId = 5,
                    Description = "ToDo",
                    ImageUrl = "/images/books/86960c70-fd36-4ed1-94f9-3ecb8c47aa5a.jpg",
                },
                new Book
                {
                    Id = 24,
                    Title = "Il pastor fido",
                    Author = "Battista Guarini",
                    ISBN = "OL17974570M",
                    NumOfPages = 262,
                    Price = 32.5m,
                    CategoryId = 5,
                    Description = "ToDo",
                    ImageUrl = "/images/books/b977e8e1-30eb-44a8-b70b-88a87fb7bbe5.jpg",
                },
                new Book
                {
                    Id = 25,
                    Title = "Introductory mathematical analysis",
                    Author = "Ernest F. Haeussler",
                    ISBN = "0130338559",
                    NumOfPages = 822,
                    Price = 79.9m,
                    CategoryId = 3,
                    Description = "ToDo",
                    ImageUrl = "/images/books/d31de0aa-e93a-4122-ae68-a894811f66d1.jpg",
                },
                new Book
                {
                    Id = 26,
                    Title = "Introduction to finite mathematics",
                    Author = "John G. Kemeny",
                    ISBN = "013468835X",
                    NumOfPages = 465,
                    Price = 59.9m,
                    CategoryId = 3,
                    Description = "ToDo",
                    ImageUrl = "/images/books/875ef8c0-31d5-476f-bd2c-0b1bd35aea0f.jpg",
                },
                new Book
                {
                    Id = 27,
                    Title = "Pro ASP .NET Core 6",
                    Author = "Adam Freeman",
                    ISBN = "OL5818599M",
                    NumOfPages = 264,
                    Price = 35.5m,
                    CategoryId = 2,
                    Description = "ToDo",
                    ImageUrl = "/images/books/b907a2b2-c4f3-4233-aef4-a0c46098a6df.jpg",
                },
            };

            return books;
        }
    }
}
