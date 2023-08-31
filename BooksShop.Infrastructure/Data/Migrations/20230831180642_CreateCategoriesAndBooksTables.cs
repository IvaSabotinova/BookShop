using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksShop.Data.Migrations
{
    public partial class CreateCategoriesAndBooksTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Messages",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Messages",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Messages",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Messages",
                type: "nvarchar(330)",
                maxLength: 330,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumOfPages = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Economics" },
                    { 2, "Technology" },
                    { 3, "Mathematics" },
                    { 4, "Medicine" },
                    { 5, "History" },
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedOn", "Description", "ISBN", "ImageUrl", "NumOfPages", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Bradley R. Schiller", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7826), "ToDo", "007100940X", "/images/books/90e0e436-1c66-41ad-88e6-e1a153404144.jpg", 969, 25.8m, "The economy today" },
                    { 2, "John Stuart Mill", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7872), "ToDo", "OL25914464M", "/images/books/73174e87-d6b4-4604-9712-7330ab87ed72.jpg", 1013, 96.4m, "Principles of political economy" },
                    { 3, "Jose Rizal", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7874), "ToDo", "OL14042495M", "/images/books/b8422c70-aebe-4333-8908-0a59b53e9ab3.jpg", 502, 38.2m, "The social cancer" },
                    { 4, "Andrew S. Tanenbaum", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7877), "ToDo", "013162959X", "/images/books/0355b9fb-bf1b-4ae5-a3b9-a88ea551f1b5.jpg", 658, 99.9m, "Computer networks" },
                    { 5, "June Jamrich Parsons and Dan Oja", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7880), "ToDo", "0760034397", "/images/books/e538ff43-dded-46c1-b7e9-f33cd2096314.jpg", 313, 75.0m, "Computer concepts" },
                    { 6, "Robert H. Blissmer", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7883), "ToDo", "0471617830", "/images/books/e5089e94-d32f-43f0-9c85-25b5ecdfcd2e.jpg", 445, 45.5m, "Introducing Computers" },
                    { 7, "Mario F. Triola", 3, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7886), "ToDo", "0805393277", "/images/books/04fe7e81-299e-4b26-b1fd-0e1a3149c9da.jpg", 581, 105.5m, "Elementary statistics" },
                    { 8, "Howard Anton", 3, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7889), "ToDo", "0471153060", "/images/books/005f0140-65ad-4b24-8f05-b2d45f274f49.jpg", 1130, 80.0m, "Calculus" },
                    { 9, "Silvanus Phillips Thompson", 3, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7891), "ToDo", "0312114109", "/images/books/8b457390-2df6-4f02-9a0b-6b3fe4890d85.jpg", 250, 75.5m, "Calculus made easy" },
                    { 10, "Soraya de Chadarevian and Harmke Kamminga", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7928), "ToDo", "9057022931", "/images/books/aa23bf8b-685c-430d-a256-7b684dd1cb90.jpg", 304, 99.0m, "Molecularizing biology and medicine" },
                    { 11, "James A. Gillespie", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7931), "ToDo", "0521381835", "/images/books/27486390-9981-468b-93ad-c4cb1c8087ab.jpg", 358, 85.0m, "The price of health" },
                    { 12, "Pickering, George White Sir", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7933), "ToDo", "019519800X", "/images/books/3faa928e-f41d-4710-a469-b8b357eef1ba.jpg", 327, 60.0m, "Creative malady" },
                    { 13, "Richard G. Lipsey", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7936), "ToDo", "0060440163", "/images/books/fcc69c01-79fd-45b8-82cc-d7011b5493bc.jpg", 927, 98.5m, "Economics" },
                    { 14, "Adam Smith and Andrew Skinner", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7938), "ToDo", "067940564X", "/images/books/b449a8b1-84f1-44dd-8c6d-e965b6efa90b.jpg", 620, 68.5m, "The wealth of nations" },
                    { 15, "Hannah Arendt", 1, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7941), "ToDo", "0226025926", "/images/books/3f3d222a-2401-437c-81b0-7db157cef7af.jpg", 365, 65.0m, "The human condition" },
                    { 16, "Kenneth C. Laudon", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7943), "ToDo", "0072472618", "/images/books/3f569900-cc2e-4f9d-ac96-54cddcd7e4e6.jpg", 632, 62.0m, "The Interactive Computing" },
                    { 17, "Larry E. Long", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7946), "ToDo", "013156241X", "/images/books/22ec6be5-99cc-4e1b-91b8-0459f964cfdf.jpg", 677, 78.0m, "Computers" },
                    { 18, "Marshall C. Yovits", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7950), "ToDo", "012012114X", "/images/books/27cd64b2-01d7-4d33-bf31-ba2d9f5ef27a.jpg", 299, 69.0m, "Advances in Computers" },
                    { 19, "Angela Belli and John L. Coulehan", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7952), "ToDo", "0877456372", "/images/books/e194f5d1-1914-4ab7-ba69-f2c24cd46e03.jpg", 160, 69.9m, "Blood & bone" },
                    { 20, "AnElissa Lucas", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7955), "ToDo", "0030594545", "/images/books/6dff32cc-dcbc-425a-8406-6463b36678df.jpg", 188, 35.0m, "Chinese medical modernization" },
                    { 21, "Richard Selzer", 4, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7957), "ToDo", "0312186878", "/images/books/3cc142ee-2ac0-4cee-8a63-d88d271d0c86.jpg", 389, 40.0m, "The doctor stories" },
                    { 22, "Elliott, Carl and John D. Lantos", 5, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7960), "ToDo", "0822323362", "/images/books/3c0e44e3-4cb5-4c12-845e-5179e4b82717.jpg", 167, 52.9m, "The last physician" },
                    { 23, "Aldous Huxley", 5, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7962), "ToDo", "0060120355", "/images/books/86960c70-fd36-4ed1-94f9-3ecb8c47aa5a.jpg", 311, 30.0m, "Brave New World" },
                    { 24, "Battista Guarini", 5, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7965), "ToDo", "OL17974570M", "/images/books/b977e8e1-30eb-44a8-b70b-88a87fb7bbe5.jpg", 262, 32.5m, "Il pastor fido" },
                    { 25, "Ernest F. Haeussler", 3, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7967), "ToDo", "0130338559", "/images/books/d31de0aa-e93a-4122-ae68-a894811f66d1.jpg", 822, 79.9m, "Introductory mathematical analysis" },
                    { 26, "John G. Kemeny", 3, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7970), "ToDo", "013468835X", "/images/books/875ef8c0-31d5-476f-bd2c-0b1bd35aea0f.jpg", 465, 59.9m, "Introduction to finite mathematics" },
                    { 27, "Adam Freeman", 2, new DateTime(2023, 8, 31, 21, 6, 42, 337, DateTimeKind.Local).AddTicks(7972), "ToDo", "OL5818599M", "/images/books/b907a2b2-c4f3-4233-aef4-a0c46098a6df.jpg", 264, 35.5m, "Pro ASP .NET Core 6" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(330)",
                oldMaxLength: 330);
        }
    }
}
