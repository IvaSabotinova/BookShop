#nullable disable

namespace BooksShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class CreateTablesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Messages",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b2e26a49-1cd2-47b3-ba2b-2211e7d851e6", "Client", "CLIENT" },
                    { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "6610b899-c6bf-4036-9831-ad602745c824", "Administrator", "ADMINISTRATOR" },
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredOn", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "038e5319-0910-4cba-bf80-253a10030324", 0, "Lazur Quarter block 13, Bourgas 8000, Bulgaria", "55fd1855-b9d5-44f9-85e2-93d5418762bd", "dinko@abv.bg", true, "Dinko", "Martinov", false, null, "DINKO@ABV.BG", "DINKO", "AQAAAAEAACcQAAAAEOZsRj2snTkJs9TB0b1Z2YJkHi39ZlKHX3YOKTqBwqWW3PXLVuaw7ov87sft1N6DxQ==", "+359888124578", false, new DateTime(2023, 9, 9, 16, 54, 26, 696, DateTimeKind.Local).AddTicks(2760), "9a991dfd-1d0e-4e4a-8ec1-3d2560f3b564", false, "Dinko" },
                    { "0908214c-eac6-4029-b303-8d987037c4ad", 0, "Primorski Blvd 7, Varna 9000, Bulgaria", "bdba2eda-b0c4-43d7-bcd9-e6e569aa0e69", "martin@abv.bg", true, "Martin", "Martinov", false, null, "MARTIN@ABV.BG", "MARTIN123", "AQAAAAEAACcQAAAAEIEM3KrhFFL4jV5wyyKL3NXCX9L5ccyPqzPrOgDM2nRuUGnEtYK4/yo3wITIGS9Thw==", "+359898554554", false, new DateTime(2023, 9, 9, 16, 54, 26, 671, DateTimeKind.Local).AddTicks(8254), "d4020c10-0734-49a4-9b52-a3d89f0fc88d", false, "Martin123" },
                    { "0e6103a7-8dae-4d2e-b438-74fe02768f4f", 0, "Izgrev Quarter block 6, Bourgas 8000, Bulgaria", "7eacb3c2-9b5c-4caf-8e83-8ed7c666cb1f", "stanislav@abv.bg", true, "Stanislav", "Georgiev", false, null, "STANISLAV@ABV.BG", "STANISLAV", "AQAAAAEAACcQAAAAECeceMf6Lwe6jUkOoNUtPAh7NF10AheMSYCPi9isIyu26b0hs4n2t04sG8kFsTOe/A==", "+359877711771", false, new DateTime(2023, 9, 9, 16, 54, 26, 682, DateTimeKind.Local).AddTicks(9009), "6d66bd38-70a7-45a9-b03a-95a96cf4ba2a", false, "Stanislav" },
                    { "109044cd-44fb-470c-b7b9-2724987b08de", 0, "Lazur Quarter block 80, Bourgas 8000, Bulgaria", "51f79f83-0656-4153-9087-4062d292bdcb", "yovko@abv.bg", true, "Yovko", "Ivov", false, null, "YOVKO@ABV.BG", "YOVKO", "AQAAAAEAACcQAAAAEOY4FcVmRMo0yKc3/VaIpjE2I9HT8PHsXtN9Topx333ZTU61NOx3HBZxLn7zQ/BGCQ==", "+359876262626", false, new DateTime(2023, 9, 9, 16, 54, 26, 685, DateTimeKind.Local).AddTicks(1320), "6c760a4c-9c89-4db3-96a4-7b93681a6444", false, "Yovko" },
                    { "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca", 0, "Slaveykov Quarter block 20, Bourgas 8000, Bulgaria", "497f7eb5-ae47-457b-ad27-534481c0b5ab", "boyan@abv.bg", true, "Boyan", "Atanasov", false, null, "BOYAN@ABV.BG", "BOYAN", "AQAAAAEAACcQAAAAEBONdZoBs+iiVCH3SmLlIEoc8W7Ac5RXQqRSxYHdADT3uzWeFcIYwkYUhKxyZJOnkQ==", "+359877742247", false, new DateTime(2023, 9, 9, 16, 54, 26, 688, DateTimeKind.Local).AddTicks(4745), "6e909c79-a9ab-4215-a77e-927ded74fe65", false, "Boyan" },
                    { "1de2f067-3236-4b27-9fba-8b5d49db06ae", 0, "Slaveykov Quarter block 68, Bourgas 8000, Bulgaria", "c5a59c8b-9580-4684-85a7-c9c2c59156d0", "dimitar@abv.bg", true, "Dimitar", "Dimitrov", false, null, "DIMITAR@ABV.BG", "DIMITAR", "AQAAAAEAACcQAAAAEGxXMdiuLYzG1hd52srZALjeE4IFZgH5ecXVaTwy2u0xzDGG44nNz2f5P2pXYCz0OQ==", "+359888181818", false, new DateTime(2023, 9, 9, 16, 54, 26, 698, DateTimeKind.Local).AddTicks(5263), "ad09c3f8-cf97-4931-ab5a-9c97ac966285", false, "Dimitar" },
                    { "22657eba-f41a-4bb3-986e-83ef23fedf15", 0, "Vl. Varnenchik block 14, Varna 9000, Bulgaria", "21d6014e-30e2-4813-b9ed-a273fa045c27", "lyuben@abv.bg", true, "Lyuben", "Nikolov", false, null, "LYUBEN@ABV.BG", "LYUBEN", "AQAAAAEAACcQAAAAELiRwyh4+CahnRi2wJNbbM5I2nCxzaB7uoDR3qPSRDHnoGom+1umg50qIbzmckCWfw==", "+359897357357", false, new DateTime(2023, 9, 9, 16, 54, 26, 695, DateTimeKind.Local).AddTicks(1704), "c5cdc1a0-2604-4db9-9403-d2ac7f1f88e6", false, "Lyuben" },
                    { "2708e501-67b2-4c5b-aacd-9a044df9de21", 0, "Slaveykov block 31, Bourgas 8000, Bulgaria", "721a752c-1c14-4e65-9895-0fd710b6698e", "atanas@abv.bg", true, "Atanas", "Mitev", false, null, "ATANAS@ABV.BG", "ATANAS", "AQAAAAEAACcQAAAAEK45+lPInfxVscXV0r4MvjRGixUnJYtYQN4WpIRXpSgXbDhXy/XAVTDdjXJYnSdrXw==", "+359899313131", false, new DateTime(2023, 9, 9, 16, 54, 26, 677, DateTimeKind.Local).AddTicks(3559), "c3494dee-703c-4e8f-9c58-b4aa1c3a7a01", false, "Atanas" },
                    { "283073f1-cc28-485a-ab58-44f4ed128264", 0, "Izgrev block 41, Bourgas 8000, Bulgaria", "3f6d0564-a78e-434e-babf-c6974544ad48", "admin@gmail.com", true, "Iva", "Sabotinova", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOCpmbZoq84MJzAa482nwHXvkmqc8po/uf/h0oGrRv+eEAvpW2sA8bwNbgq/NfK0xQ==", "+359889694030", false, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1456), "26ee4080-b76a-45f1-b358-2ce4e9a6d04e", false, "admin" },
                    { "2b760fe4-01b3-4794-9d1a-a63002dc3ccd", 0, "Izgrev Quarter block 29, Bourgas 8000, Bulgaria", "966fa100-b284-463e-8a80-783261c1f221", "simona@abv.bg", true, "Simona", "Georgieva", false, null, "SIMONA@ABV.BG", "SIMONA", "AQAAAAEAACcQAAAAEKr6C+A3Srl3ystzyJlhKqMzYyrPvmfPSh4gLOgl1Sv4Nwr1klaU/4f0ctNHn1MR8g==", "+359888333333", false, new DateTime(2023, 9, 9, 16, 54, 26, 678, DateTimeKind.Local).AddTicks(4684), "de5d6623-daae-4896-b3eb-b803c7ad801e", false, "Simona" },
                    { "2c2467dc-c396-46ce-af79-da3e48398f4a", 0, "Vazrazhdane Quarter block 70, Bourgas 8000, Bulgaria", "061c0dc3-7f45-4c89-b84b-85cc2bf98264", "rayko@abv.bg", true, "Rayko", "Yasenov", false, null, "RAYKO@ABV.BG", "RAYKO", "AQAAAAEAACcQAAAAEC8W7wgztPNVP/5A3htFu52EwJ8NWcWc/qbSG6aLaztK3RhRsyqnUkgf61E7e5yzOg==", "+359888658974", false, new DateTime(2023, 9, 9, 16, 54, 26, 675, DateTimeKind.Local).AddTicks(1351), "7634d611-3feb-4e61-b064-57f53f8d6699", false, "Rayko" },
                    { "33008499-b5d6-4dc4-8b90-81eb4c5da11e", 0, "Hr. Boteb Blvd block 5, Bourgas 8000, Bulgaria", "a6ea409c-700e-4a86-a591-1abbac0d7b8b", "genadi@abv.bg", true, "Genadi", "Atanasov", false, null, "GENADI@ABV.BG", "GENADI", "AQAAAAEAACcQAAAAENux76qwkq8BIIl0n/7I0FGS23iAaDxpJ+sxOw+b9lzbtgeG1mDwx7dHqLfhbpzZTw==", "+359899369369", false, new DateTime(2023, 9, 9, 16, 54, 26, 690, DateTimeKind.Local).AddTicks(7085), "c924f152-4cc5-4b12-81da-11b316687992", false, "Genadi" },
                    { "45538c3e-df96-4b79-86dc-e190def35cf4", 0, "Lazur block 33, Bourgas 8000, Bulgaria", "7a0cc94b-5d76-4b1a-bf28-fc3ae429682c", "gosho@gmail.com", true, "Gosho", "Goshev", false, null, "GOSHO@GMAIL.COM", "GOSHO", "AQAAAAEAACcQAAAAEDm3nYpvET7EMMCVNJTuuAS0x5S6fAEof8gtI6wcekheFCfO54kByRnduNGCov9+zQ==", "+359877111111", false, new DateTime(2023, 9, 9, 16, 54, 26, 667, DateTimeKind.Local).AddTicks(3779), "3b076ecf-b803-4cac-be45-6f9da1305e04", false, "Gosho" },
                    { "77eb1836-14d0-414d-85ad-3413afd9e2d9", 0, "Stefan Stambolov Blvd 8, Bourgas 8000, Bulgaria", "82e1c373-3fe2-4680-90fe-6235425b5546", "valeri@abv.bg", true, "Valeri", "Yovkov", false, null, "VALERI@ABV.BG", "VALERI", "AQAAAAEAACcQAAAAEGWO4EyDZS4jaZ3on8mT5wasVdVGEntBTzxiWnf5Cgh/z4zeE465m7hCDeFjN90OtQ==", "+359888121210", false, new DateTime(2023, 9, 9, 16, 54, 26, 672, DateTimeKind.Local).AddTicks(9279), "395cb9c0-381e-4a02-adcf-7c4ead064904", false, "Valeri" },
                    { "7a09fc16-8d35-48e4-bf98-532a876423f2", 0, "Vl.Varnenchik block 8, Varna 9000, Bulgaria", "9e9787af-84c9-47f6-aa0c-22e5c30866bc", "nikola80@abv.bg", true, "Nikola", "Petrov", false, null, "NIKOLA80@ABV.BG", "NIKOLA", "AQAAAAEAACcQAAAAEPT0WFI7NRWJBQoT9Sru4Ef+L/mCkENStNo7fxpCe/0A61AcpQKVZlkuZSfKIVzc2w==", "+359899555555", false, new DateTime(2023, 9, 9, 16, 54, 26, 670, DateTimeKind.Local).AddTicks(7193), "80a067a4-3e74-42cc-8f30-94ede13a0c70", false, "Nikola" },
                    { "838db25f-ef7e-4cda-aa56-dfe1691d298d", 0, "Mara Gidik Street block 4, Bourgas 8000, Bulgaria", "563c07f5-dbb0-4175-9563-46313715a73f", "desislav@abv.bg", true, "Desislav", "Stoyanov", false, null, "DESISLAV@ABV.BG", "DESISLAV", "AQAAAAEAACcQAAAAEGSbmzdnWQ5hTL8mse9GvOHUzN9fYzjGNZaj/VpxhAycmkaD9TO3v/nTPLGa1DZ+Kg==", "+359899949596", false, new DateTime(2023, 9, 9, 16, 54, 26, 694, DateTimeKind.Local).AddTicks(764), "fbc818ba-5aea-4fbf-aec1-47ed2137f96f", false, "Desislav" },
                    { "87582ce2-32f8-48ac-a429-cdb22d49bd45", 0, "Vazrazhdane Quarter block 71, Bourgas 8000, Bulgaria", "d76d7b04-4e0a-4c38-b018-97416a49c5cb", "yasen@abv.bg", true, "Yasen", "Ivanov", false, null, "YASEN@ABV.BG", "YASEN", "AQAAAAEAACcQAAAAEB/PlJu/FI58+mDlYYXLgWPLC0tqtjaQng0GEBwYGdWcFvhnBzdBA4t96DWoxNsL9Q==", "+359888656565", false, new DateTime(2023, 9, 9, 16, 54, 26, 676, DateTimeKind.Local).AddTicks(2360), "6371d6ae-53d9-49dd-9590-480ce222d285", false, "Yasen" },
                    { "8a702a88-26b5-4e9d-bd3e-6b088b350db5", 0, "Hr. Boteb Blvd block 2, Bourgas 8000, Bulgaria", "a948b9f1-da2e-47fe-9a23-20965992b2bd", "dragomir@abv.bg", true, "Dragomir", "Martinov", false, null, "DRAGOMIR@ABV.BG", "DRAGOMIR", "AQAAAAEAACcQAAAAEOuoJSrSQILEFVzF7UQXlsX7TK3N038vKmwB/Q7d4MoH9DzYXnbk29soHL/DRNa+dA==", "+359888258258", false, new DateTime(2023, 9, 9, 16, 54, 26, 691, DateTimeKind.Local).AddTicks(8403), "f20ad080-e736-4b21-bd74-f1c65ab9c420", false, "Dragomir" },
                    { "8d307bd3-3290-43c2-b9b3-eb2daf715cb4", 0, "Vl.Varnenchik block 50, Varna 9000, Bulgaria", "67035692-80c3-4891-9028-5a9f69867c83", "mara@abv.bg", true, "Mara", "Petrova", false, null, "MARA@ABV.BG", "MARA", "AQAAAAEAACcQAAAAEKy5OSymd23/nF5UgG36IK4m0KvQTcUUrP3hXsfLIFxWr5ZLShxbnt1cViR5yTuv2g==", "+359888556556", false, new DateTime(2023, 9, 9, 16, 54, 26, 669, DateTimeKind.Local).AddTicks(6095), "195f913e-ece7-44d2-9919-962e7ba41044", false, "Mara001" },
                    { "93a879f7-64a2-4a8c-b821-a1304bd7c8fb", 0, "Vazrazhdane Quarter block 50, Bourgas 8000, Bulgaria", "f7207d96-d37c-4d14-a446-491bf78be2d7", "yovka@abv.bg", true, "Yovka", "Yasenova", false, null, "YOVKA@ABV.BG", "YOVKA", "AQAAAAEAACcQAAAAEGL2yTEct5+EezzYYM8f6+YaqUF7QXaYQ/HTAmTmOva+ERwANVIqDFm5OScJWZdyrQ==", "+359998919119", false, new DateTime(2023, 9, 9, 16, 54, 26, 686, DateTimeKind.Local).AddTicks(2555), "63ad0050-cd99-4c4a-a47a-06f11cde9cb2", false, "Yovka" },
                    { "94280b80-6076-4025-9bf7-ae251fb7bcee", 0, "Izgrev Quarter block 22, Bourgas 8000, Bulgaria", "472110aa-70fa-4fb2-8aa5-588bda15b4d2", "stanislava@abv.bg", true, "Stanislava", "Ivanova", false, null, "STANISLAVA@ABV.BG", "STANISLAVA", "AQAAAAEAACcQAAAAEDmdzjRpFsGhf32+JJWHT/E1cty42xuPbhqThv5A0ed07nJ3IRdmr7IBIXc48H0cpQ==", "+359889126543", false, new DateTime(2023, 9, 9, 16, 54, 26, 684, DateTimeKind.Local).AddTicks(200), "2cd96590-ae21-4dc7-aced-1cd62b27ed93", false, "Stanislava" },
                    { "978959e9-4ec5-49a0-a703-77884cc8d109", 0, "Lazur Quarter block 16, Bourgas 8000, Bulgaria", "8961dbd1-eb4c-4d6b-b349-1ed87d96a59f", "katerina@abv.bg", true, "Katerina", "Markova", false, null, "KATERINA@ABV.BG", "KATERINA", "AQAAAAEAACcQAAAAEDnL6DhSythdtYNzCymqBYEuRODYM+063bsO0vAxpk838Z6Zja+IxLjPW1Lyr1Yqng==", "+359888951847", false, new DateTime(2023, 9, 9, 16, 54, 26, 697, DateTimeKind.Local).AddTicks(4058), "8f6b7426-4d67-4cd6-a847-6b6d259fcff6", false, "Katerina" },
                    { "9a9b36f7-4a83-48c8-91d3-9136426dbee9", 0, "Slaveykov block 33, Bourgas 8000, Bulgaria", "5f05c4ae-000c-4c80-aa55-4cf578609694", "client@gmail.com", true, "Pesho", "Martinov", false, null, "CLIENT@GMAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAECAhS8x5AN7EkVU+ToO8/EiCv+QmrnHnwHTe0zsj1EntDFml3dq6duvP+AnO3IXYYQ==", "+359877222222", false, new DateTime(2023, 9, 9, 16, 54, 26, 666, DateTimeKind.Local).AddTicks(2691), "c250c03c-a612-4339-8993-bae444e5f08b", false, "client" },
                    { "a6424f60-c8e2-495d-bf48-bfb3e9457516", 0, "Mara Gidik street 18, Bourgas 8000, Bulgaria", "dbd70afc-9e76-4eb4-942a-81e4d7846c2c", "daniel@abv.bg", true, "Daniel", "Vladislavov", false, null, "DANIEL@ABV.BG", "DANIEL", "AQAAAAEAACcQAAAAELpQAlezlRYipml/cG1x9oa2aGYNzR9RXmBW3O/LKRvP793xwNaNxd4G/8o5j06DQg==", "+359899919100", false, new DateTime(2023, 9, 9, 16, 54, 26, 680, DateTimeKind.Local).AddTicks(6964), "76054070-2877-4dd6-aa2f-fe98535dd717", false, "Daniel" },
                    { "a6dc0238-4999-49e9-93c1-dfd243e36781", 0, "Mara Gidik Street block 8, Bourgas 8000, Bulgaria", "55baeb01-76d5-433e-8e9b-ffc9cadbfaaf", "ilian@abv.bg", true, "Ilian", "Stoyanov", false, null, "ILIAN@ABV.BG", "ILIAN", "AQAAAAEAACcQAAAAEPPKeUkQIKvdIIaxI8ek4K/TcYQuK5FG3g7ngLcrnAfW6Vd4Xnc1kI4giJo57CbRrg==", "+359888654789", false, new DateTime(2023, 9, 9, 16, 54, 26, 692, DateTimeKind.Local).AddTicks(9446), "e683feb9-9bf0-403f-aa94-1da911433d2a", false, "Ilian" },
                    { "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b", 0, "Troikata Square block 1, Bourgas 8000, Bulgaria", "31f92fec-8b94-4464-9228-2bfa247db327", "vlado20@abv.bg", true, "Vlado", "Ivanov", false, null, "VLADO20@ABV.BG", "VLADO20", "AQAAAAEAACcQAAAAEOxX03XzCQpZZnB8tBF2ciOKIfIRgCLV55XBd+QAwpdZcqzqqTFY+pRPCgyBPI3jzg==", "+359877334334", false, new DateTime(2023, 9, 9, 16, 54, 26, 668, DateTimeKind.Local).AddTicks(4802), "859dbd0b-3db4-49d8-ad08-032bfa8f0b8c", false, "Vlado20" },
                    { "acb6d047-97c5-4553-82cf-d6042362af1e", 0, "Mara Gidik street 29, Bourgas 8000, Bulgaria", "307316d3-e729-4e6b-9d0e-7e61d2a6dae5", "denislav@abv.bg", true, "Denislav", "Georgiev", false, null, "DENISLAV@ABV.BG", "DENISLAV", "AQAAAAEAACcQAAAAEANNpHPlZ7pxEquLdkFVXkCzq1XWGWngrsJOU9WP6xlG3tSxkVk8iaEU0PHj0UunSA==", "+359888010101", false, new DateTime(2023, 9, 9, 16, 54, 26, 679, DateTimeKind.Local).AddTicks(5918), "3aedfb99-e864-432b-9586-bbb531218240", false, "Denislav" },
                    { "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc", 0, "Gladstone street block 6, Bourgas 8000, Bulgaria", "a1adb9d1-10bd-4b45-94dd-f482e7bea5e7", "daniela@abv.bg", true, "Daniela", "Ivanova", false, null, "DANIELA@ABV.BG", "DANIELA", "AQAAAAEAACcQAAAAEKTvUpo9bYqWKM9zOKLYeFsYhJBy19XdFSS+DOAzIfkuy3sBBpWpWCGSz+hB4XbaCQ==", "+359888030330", false, new DateTime(2023, 9, 9, 16, 54, 26, 681, DateTimeKind.Local).AddTicks(7870), "db974193-e887-4922-8dee-e5e944374b2c", false, "Daniela" },
                    { "b87fc486-a805-4fad-89bd-c836281ce8a0", 0, "Slaveykov Quarter block 17, Bourgas 8000, Bulgaria", "62e69d37-0ae5-4be7-a481-019c554f97eb", "boyana@abv.bg", true, "Boyana", "Marinova", false, null, "BOYANA@ABV.BG", "BOYANA", "AQAAAAEAACcQAAAAECNVRx7Ll9540TT/tc+Bdy0pOW8+IEpThNM2KZ7tBiwIx9trJTUn6iQvEJKkqOFEOw==", "+359888159159", false, new DateTime(2023, 9, 9, 16, 54, 26, 689, DateTimeKind.Local).AddTicks(5855), "4b9c8d83-cd4b-4151-8662-ac6ad8285aac", false, "Boyana" },
                    { "d966a121-573e-49ed-bf9b-5f677d0a4aa8", 0, "Vazrazhdane Quarter block 49, Bourgas 8000, Bulgaria", "5f9eea8c-a73f-4732-ab96-906fe5d44ecb", "boiko@abv.bg", true, "Boiko", "Asenov", false, null, "BOIKO@ABV.BG", "BOIKO", "AQAAAAEAACcQAAAAELWuL0pCa3/BmXxHyv0Ez9aXvmFueSZmwXwE/nb9+80099ecfkQGmz0ulrMY2GgwgQ==", "+359888147147", false, new DateTime(2023, 9, 9, 16, 54, 26, 687, DateTimeKind.Local).AddTicks(3567), "a25406a7-8e6c-4040-ace4-2d77aa7a5579", false, "Boiko" },
                    { "f18ff312-2889-46df-a392-264b865a2c72", 0, "Hr. Botev Blvd 85, Bourgas 8000, Bulgaria", "ec954236-d9ca-4ad8-aaf9-e72ac41e0d4c", "gogo@abv.bg", true, "Gogo", "Goshev", false, null, "GOGO@ABV.BG", "GOGO", "AQAAAAEAACcQAAAAED1PU4W6K81+Hx0ig0y7RaAscx5Uuhruq7K+PYIat4szCkzLMheb6R0oM5PWF+2fsg==", "+359898331456", false, new DateTime(2023, 9, 9, 16, 54, 26, 674, DateTimeKind.Local).AddTicks(350), "71bf3ef3-9bc9-4075-9796-1c78578ce144", false, "Gogo" },
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
                    { 6, "Other" },
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "038e5319-0910-4cba-bf80-253a10030324" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "0908214c-eac6-4029-b303-8d987037c4ad" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "0e6103a7-8dae-4d2e-b438-74fe02768f4f" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "109044cd-44fb-470c-b7b9-2724987b08de" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "1de2f067-3236-4b27-9fba-8b5d49db06ae" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "22657eba-f41a-4bb3-986e-83ef23fedf15" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2708e501-67b2-4c5b-aacd-9a044df9de21" },
                    { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "283073f1-cc28-485a-ab58-44f4ed128264" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2b760fe4-01b3-4794-9d1a-a63002dc3ccd" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2c2467dc-c396-46ce-af79-da3e48398f4a" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "33008499-b5d6-4dc4-8b90-81eb4c5da11e" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "45538c3e-df96-4b79-86dc-e190def35cf4" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "77eb1836-14d0-414d-85ad-3413afd9e2d9" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "7a09fc16-8d35-48e4-bf98-532a876423f2" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "838db25f-ef7e-4cda-aa56-dfe1691d298d" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "87582ce2-32f8-48ac-a429-cdb22d49bd45" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "8a702a88-26b5-4e9d-bd3e-6b088b350db5" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "8d307bd3-3290-43c2-b9b3-eb2daf715cb4" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "93a879f7-64a2-4a8c-b821-a1304bd7c8fb" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "94280b80-6076-4025-9bf7-ae251fb7bcee" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "978959e9-4ec5-49a0-a703-77884cc8d109" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "9a9b36f7-4a83-48c8-91d3-9136426dbee9" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a6424f60-c8e2-495d-bf48-bfb3e9457516" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a6dc0238-4999-49e9-93c1-dfd243e36781" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "acb6d047-97c5-4553-82cf-d6042362af1e" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b87fc486-a805-4fad-89bd-c836281ce8a0" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "d966a121-573e-49ed-bf9b-5f677d0a4aa8" },
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "f18ff312-2889-46df-a392-264b865a2c72" },
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedOn", "Description", "ISBN", "ImageUrl", "NumOfPages", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Bradley R. Schiller", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(932), "The Economy Today is noted for three great strengths: currency, policy focus, and readability. The accessible writing style engages students and brings the excitement of domestic and global economic news into the classroom.\r\n\r\nSchiller/Gebhardt emphasizes how policymakers must choose between government intervention and market reliance to resolves the core issues of what, how, and for whom to produce. These strategic trade-offs are highlighted throughout the full range of micro, macro, and international issues, and every chapter ends with a policy issue that emphasizes the market versus government dilemma.\r\n\r\nThe authors teach economics in a current and relevant context, including the COVID Pandemic of 2020, filling chapters with the real facts and applications of economic life. Schiller/Gebhardt is also the only principles text that presents all macro theory in the single consistent context of the AS/AD framework and uniquely features a full supply-side economics chapter. You will also find the current Economist and Chief, Joe Biden, featured in the opening chapter. \r\n\r\nThe authors have worked to ensure The Economy Today, 16th edition, is tightly integrated with the adaptive digital tools and dynamic interactive resources available in Connect. Connect is proven to increase student engagement and success. For professors there is also an updated instructor guide to bring new ideas to your course, no matter the format.", "007100940X", "/images/books/90e0e436-1c66-41ad-88e6-e1a153404144.jpg", 969, 25.8m, "The economy today" },
                    { 2, "John Stuart Mill", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(973), "The Principles of Political Economy with some of their applications to Social Philosophy by John Stuart Mill. Principles of Political Economy (1848) by John Stuart Mill was one of the most important economics or political economy textbooks of the mid-nineteenth century. It was revised until its seventh edition in 1871, shortly before Mill's death in 1873, and republished in numerous other editions. In every department of human affairs, Practice long precedes Science systematic enquiry into the modes of action of the powers of nature, is the tardy product of a long course of efforts to use those powers for practical ends. The conception, accordingly, of Political Economy as a branch of science is extremely modern; but the subject with which its enquiries are conversant has in all ages necessarily constituted one of the chief practical interests of mankind, and, in some, a most unduly engrossing one. That subject is Wealth. Writers on Political Economy profess to teach, or to investigate, the nature of Wealth, and the laws of its production and distribution: including, directly or remotely, the operation of all the causes by which the condition of mankind, or of any society of human beings, in respect to this universal object of human desire, is made prosperous or the reverse. Not that any treatise on Political Economy can discuss or even enumerate all these causes; but it undertakes to set forth as much as is known of the laws and principles according to which they operate.", "OL25914464M", "/images/books/73174e87-d6b4-4604-9712-7330ab87ed72.jpg", 1013, 96.4m, "Principles of political economy" },
                    { 3, "Jose Rizal", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(975), "One of the most popular novels of its day, this translation of The Social Cancer shows just why with a vibrant, lively translation that leaps off the page.", "OL14042495M", "/images/books/b8422c70-aebe-4333-8908-0a59b53e9ab3.jpg", 502, 38.2m, "The social cancer" },
                    { 4, "Andrew S. Tanenbaum", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(978), "In Computer Networks,Tanenbaum et al. explain how networks work from the inside out. They start with the physical layer of networking, computer hardware and transmission systems,then work their way up to network applications. Each chapter follows aconsistent approach: The book presents key principles, then illustrates them utilizing real-world example networks that run through the entire book – the Internet, and wireless networks, including Wireless LANs, broadband wireless,and Bluetooth. The 6th Edition is updated throughout to reflect the most current technologies, and the chapter on network security is rewritten to focus on modern security principles and actions.\r\n\r\nTutorial videos on key networking topics and techniques are available to students on the companion website at www.pearsonglobaleditions.com\r\n\r\nInstructors are supported with a SolutionsManual to end-of-chapter exercises featured in the book, LecturePowerPoint slides, and extracted art and figures featured in thebook.", "013162959X", "/images/books/0355b9fb-bf1b-4ae5-a3b9-a88ea551f1b5.jpg", 658, 99.9m, "Computer networks" },
                    { 5, "June Jamrich Parsons and Dan Oja", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(981), "Helping you understand the technological foundations for a wide range of digital devices, New Perspectives Computer Concepts Comprehensive, 21st edition, presents what every learner should know about using technology to complete your education, launch a successful career and engage in issues that shape today's world. The book's proven learning path is structured with today's busy reader in mind. Leading tech author June Parsons combines the latest on emerging technology with detailed illustrations and interactive activities that help you quickly understand technical topics. This edition provides updated information on current operating systems, digital rights management, the deep web and dark web, videoconferencing, the pandemic's impact on tech jobs, work-at-home and more. A unique module provides a hands-on introduction to programming, while MindTap offers anywhere, anytime learning solutions.", "0760034397", "/images/books/e538ff43-dded-46c1-b7e9-f33cd2096314.jpg", 313, 75.0m, "Computer concepts" },
                    { 6, "Robert H. Blissmer", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(984), "This annual edition offers up-to-the-minute information on technological innovation and change along with a built-in study guide. Outlines the essential skills needed to achieve computer literacy including key concepts, systems and applications. Accessible, yet technically accurate, each major concept is supported by an application and illustration. Numerous software exercises provide projects for students to practice on the computer.", "0471617830", "/images/books/e5089e94-d32f-43f0-9c85-25b5ecdfcd2e.jpg", 445, 45.5m, "Introducing Computers" },
                    { 7, "Mario F. Triola", 3, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(987), "Best-selling author Marty Triola is committed to keeping Elementary Statistics relentlessly current - with an unprecedented amount of up-to-the-minute real data - so that readers of all backgrounds understand the role of statistics in the world around them. In addition to an abundance of new data sets, examples, and exercises, the 13th Edition is designed to be even more flexible, with the addition of learning objectives as an organizational tool, larger data sets, and new topics in line with advancements in statistics. In addition, readers will find more support in an all - new series of videos, more opportunities for practice, and improved support for statistical software. Elementary Statistics is part of a series that also includes an Essentials version as well as technology-specific texts, Elementary Statistics Using the TI 83/84 Plus Calculator and Elementary Statistics Using Excel.", "0805393277", "/images/books/04fe7e81-299e-4b26-b1fd-0e1a3149c9da.jpg", 581, 105.5m, "Elementary statistics" },
                    { 8, "Howard Anton", 3, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(989), "Countless people have relied on Anton to learn the difficult concepts of calculus. The new ninth edition continues the tradition of providing an accessible introduction to the field. It improves on the carefully worked and special problems to increase comprehension. New applied exercises demonstrate the usefulness of mathematics. More summary tables and step-by-step summaries are included to offer additional support when learning the concepts. And Quick Check exercises have been revised to more precisely focus on the most important ideas. This book will help anyone who needs to learn calculus and build a strong mathematical foundation.", "0471153060", "/images/books/005f0140-65ad-4b24-8f05-b2d45f274f49.jpg", 1130, 80.0m, "Calculus" },
                    { 9, "Silvanus Phillips Thompson", 3, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(992), "This major revision of the classic math text makes the subject at hand still more comprehensible to readers of all levels. With a new introduction, three new chapters, modernized language and methods throughout, and an appendix of challenging and enjoyable practice problems, Calculus Made Easy has been thoroughly updated for the modern reader.", "0312114109", "/images/books/8b457390-2df6-4f02-9a0b-6b3fe4890d85.jpg", 250, 75.5m, "Calculus made easy" },
                    { 10, "Soraya de Chadarevian and Harmke Kamminga", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(996), "The contributors present a coherent set of case studies of practices, technologies and strategies aimed at the isolation, investigation, manipulation, production, and uses of molecules including vitamins, hormones, blood products, antibiotics, and vaccines. These case studies examine how processes of molecularization were set in motion in the inter-war period, how they were used as a resource in the biomedical 'mobilization' of World War II, and how new alliances and strategies created as part of the war effort played a central role in the reorganisation of biomedicine in the post-war period.", "9057022931", "/images/books/aa23bf8b-685c-430d-a256-7b684dd1cb90.jpg", 304, 99.0m, "Molecularizing biology and medicine" },
                    { 11, "James A. Gillespie", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(999), "This book provides background to the current debate on health policy by studying the political conflict over it in Australia from 1910 to 1960. It looks at both state and national levels to identify the main structures and forces that shaped the system of publicly-subsidized private practice, which is now most obvious in the fee-for-service scheme.", "0521381835", "/images/books/27486390-9981-468b-93ad-c4cb1c8087ab.jpg", 358, 85.0m, "The price of health" },
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "CreatedOn", "Description", "ISBN", "ImageUrl", "NumOfPages", "Price", "Title" },
                values: new object[,]
                {
                    { 12, "Pickering, George White Sir", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1002), "In this interesting and entertaining work, Sir George Pickering examines the lives and careers of six very remarkable people, three men and three women. He chose them to illustrate and develop his view, previously formed, that an illness, physical or mental, that is not debilitating or disabling may play a positive part in furthering creative work. For this purpose a mental illness is better than a physical one. It can be developed to suit the circumstances; and if they change the illness may cease to have a function and disappear.", "019519800X", "/images/books/3faa928e-f41d-4710-a469-b8b357eef1ba.jpg", 327, 60.0m, "Creative malady" },
                    { 13, "Richard G. Lipsey", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1004), "Building on the success of previous editions, Economics, Twelfth Edition, has been thoroughly updated and revised. Rigorous yet also accessible to beginners, it provides comprehensive coverage of both introductory macroeconomics and microeconomics. The authors balance in-depth explanations of key theoretical concepts with a wide range of real-world examples drawn from around the globe. They incorporate numerous pedagogical features including highlighted definitions of economic terms, short revision questions, and updated end-of-chapter questions.", "0060440163", "/images/books/fcc69c01-79fd-45b8-82cc-d7011b5493bc.jpg", 927, 98.5m, "Economics" },
                    { 14, "Adam Smith and Andrew Skinner", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1007), "A Masterpiece of Economic Analysis Firstly Published in 1776 by Adam Smith—The Wealth of Nations\r\nAn American statistic shows that, due to its significant global impact, \"The Wealth of Nations by Adam Smith\" was the most important document published in 1776. This book, long considered to be the magnum opus of the Scottish philosopher and economist Adam Smith, offers a deep analysis into the causes and nature of the wealth of nations.\r\n\r\nThough first published in 1776, many of Adam Smith's arguments for raising living standards are still relevant today. More than that, they form the fundamental basis for classical economic theory.\r\n\r\nBy reflecting upon the economics at the beginning of the industrial revolution, the book treats broad topics such as the division of labor, division of stock, the progress of opulence, and more.\r\n\r\nIn the early days, economics was about the king's interests, and the wealth of a nation was measured by the king's treasury or by the gold and silver in the country.\r\n\r\nHowever, Smith believed that if everyone did what was best for themselves, the result would be best for society.\r\n\r\nThe Wealth of Nations provides the first and most eloquent integrated description of the workings of a market economy.", "067940564X", "/images/books/b449a8b1-84f1-44dd-8c6d-e965b6efa90b.jpg", 620, 68.5m, "The wealth of nations" },
                    { 15, "Hannah Arendt", 1, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1010), "The past year has seen a resurgence of interest in the political thinker Hannah Arendt, “the theorist of beginnings,” whose work probes the logics underlying unexpected transformations — from totalitarianism to revolution.\r\n\r\nA work of striking originality, The Human Condition is in many respects more relevant now than when it first appeared in 1958. In her study of the state of modern humanity, Hannah Arendt considers humankind from the perspective of the actions of which it is capable. The problems Arendt identified then — diminishing human agency and political freedom, the paradox that as human powers increase through technological and humanistic inquiry, we are less equipped to control the consequences of our actions - continue to confront us today. This new edition, published to coincide with the sixtieth anniversary of its original publication, contains Margaret Canovan’s 1998 introduction and a new foreword by Danielle Allen.\r\n\r\nA classic in political and social theory, The Human Condition is a work that has proved both timeless and perpetually timely.", "0226025926", "/images/books/3f3d222a-2401-437c-81b0-7db157cef7af.jpg", 365, 65.0m, "The human condition" },
                    { 16, "Kenneth C. Laudon", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1012), "The Interactive Computing Series is the Visual, Interactive way to develop and apply software skills. This Skills based approach coupled with its highly illustrated, 2 page-spread design is ideal for the intro CIS course, the self-paced course or students in non-traditional education settings.", "0072472618", "/images/books/3f569900-cc2e-4f9d-ac96-54cddcd7e4e6.jpg", 632, 62.0m, "The Interactive Computing" },
                    { 17, "Larry E. Long", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1015), "Providing overview coverage of computing/IT concepts and applications, Computers meets the needs of contemporary IT knowledge in content, sequence, and depth of presentation. The material in this progressive edition reflects readers' interests and spans the world of information technology. It contains seven core chapters; plus an introduction to e-commerce, database management, and IT security; as well as emerging technologies such as artificial intelligence. Also included — three colorful IT Illustrated modules: computer history, the making of integrated circuits, and a PC buyer's guide. For a comprehensive introduction to computers.", "013156241X", "/images/books/22ec6be5-99cc-4e1b-91b8-0459f964cfdf.jpg", 677, 78.0m, "Computers: Information Technology in Perspective" },
                    { 18, "Marshall C. Yovits", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1018), "Red hard cover with gilt lettering on spine and upper board in very good clean condition with small scrape on tail of spine. Pages are clean and bright throughout. Library plates on front endpapers. Library stamps on page block. Anti-theft device on back inside cover. Illustrated with numerous diagrams.", "012012114X", "/images/books/27cd64b2-01d7-4d33-bf31-ba2d9f5ef27a.jpg", 299, 69.0m, "Advances in Computers" },
                    { 19, "Angela Belli and John L. Coulehan", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1051), "An anthology of 100 poems, written by physicians, exploring the connections between medicine and poetry.", "0877456372", "/images/books/e194f5d1-1914-4ab7-ba69-f2c24cd46e03.jpg", 160, 69.9m, "Blood & bone" },
                    { 20, "AnElissa Lucas", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1054), null, "0030594545", "/images/books/6dff32cc-dcbc-425a-8406-6463b36678df.jpg", 188, 35.0m, "Chinese medical modernization" },
                    { 21, "Richard Selzer", 4, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1057), "A collection of short stories exploring what it means to tend to the sick and dying includes \"Avalanche,\" \"Whither thou goest,\" \"The Masked Marvel's last toehold,\" \"Pages from a wound dresser's diary,\" and \"Poe's lighthouse\".", "0312186878", "/images/books/3cc142ee-2ac0-4cee-8a63-d88d271d0c86.jpg", 389, 40.0m, "The doctor stories" },
                    { 22, "Elliott, Carl and John D. Lantos", 5, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1059), "Walker Percy brought to his novels the perspective of both a doctor and a patient. Trained as a doctor at Columbia University, he contracted tuberculosis during his internship as a pathologist at Bellevue Hospital and spent the next three years recovering, primarily in TB sanitoriums. This collection of essays explores not only Percy’s connections to medicine but also the underappreciated impact his art has had and can have on medicine itself.\r\nThe contributors — physicians, philosophers, and literary critics — examine the relevance of Percy’s work to current dilemmas in medical education and health policy. They reflect upon the role doctors and patients play in his novels, his family legacy of depression, how his medical background influenced his writing style, and his philosophy of psychiatry. They contemplate the private ways in which Percy’s work affected their own lives and analyze the author’s tendency to contrast the medical-scientific worldview with a more spiritual one. Assessing Percy’s stature as an author and elucidating the many ways that reading and writing can combine with diagnosing and treating to offer an antidote to despair, they ask what it means to be a doctor, a writer, and a seeker of cures and truths — not just for the body but for the malaise and diseased spirituality of modern times.\r\nThis collection will appeal to lovers of literature as well as medical professionals — indeed, anyone concerned with medical ethics and the human side of doctoring.", "0822323362", "/images/books/3c0e44e3-4cb5-4c12-845e-5179e4b82717.jpg", 167, 52.9m, "The last physician" },
                    { 23, "Aldous Huxley", 5, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1062), "Aldous Huxley's profoundly important classic of world literature, Brave New World is a searching vision of an unequal, technologically-advanced future where humans are genetically bred, socially indoctrinated, and pharmaceutically anesthetized to passively uphold an authoritarian ruling order – all at the cost of our freedom, full humanity, and perhaps also our souls. “A genius [who] who spent his life decrying the onward march of the Machine” (The New Yorker), Huxley was a man of incomparable talents: equally an artist, a spiritual seeker, and one of history’s keenest observers of human nature and civilization. Brave New World, his masterpiece, has enthralled and terrified millions of readers, and retains its urgent relevance to this day as both a warning to be heeded as we head into tomorrow and as thought - provoking, satisfying work of literature. Written in the shadow of the rise of fascism during the 1930s, Brave New World likewise speaks to a 21st-century world dominated by mass-entertainment, technology, medicine and pharmaceuticals, the arts of persuasion, and the hidden influence of elites.", "0060120355", "/images/books/86960c70-fd36-4ed1-94f9-3ecb8c47aa5a.jpg", 311, 30.0m, "Brave New World" },
                    { 24, "Battista Guarini", 5, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1065), null, "OL17974570M", "/images/books/b977e8e1-30eb-44a8-b70b-88a87fb7bbe5.jpg", 262, 32.5m, "Il pastor fido" },
                    { 25, "Ernest F. Haeussler and Richard Paul and Richard Wood", 3, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1067), "Haeussler, Paul, and Wood establish a strong algebraic foundation that sets this text apart from other applied mathematics texts, paving the way for readers to solve real-world problems that use calculus. Emphasis on developing algebraic skills is extended to the exercises ― including both drill problems and applications. The authors work through examples and explanations with a blend of rigor and accessibility. In addition, they have refined the flow, transitions, organization, and portioning of the content over many editions to optimize learning for readers. The table of contents covers a wide range of topics efficiently, enabling readers to gain a diverse understanding.", "0130338559", "/images/books/d31de0aa-e93a-4122-ae68-a894811f66d1.jpg", 822, 79.9m, "Introductory mathematical analysis" },
                    { 26, "John G. Kemeny", 3, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1070), null, "013468835X", "/images/books/875ef8c0-31d5-476f-bd2c-0b1bd35aea0f.jpg", 465, 59.9m, "Introduction to finite mathematics" },
                    { 27, "Adam Freeman", 2, new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1072), "Professional developers will produce leaner applications for the ASP.NET Core platform using the guidance in this best-selling book, now in its 9th edition and updated for ASP.NET Core for .NET 6. It contains detailed explanations of the ASP.NET Core platform and the application frameworks it supports. This cornerstone guide puts ASP.NET Core for .NET 6 into context and dives deep into the tools and techniques required to build modern, extensible web applications. New features and capabilities such as MVC, Razor Pages, Blazor Server, and Blazor WebAssembly are covered, along with demonstrations of how they are applied.\r\n\r\nASP.NET Core for .NET 6 is the latest evolution of Microsoft’s ASP.NET web platform and provides a \"host-agnostic\" framework and a high-productivity programming model that promotes cleaner code architecture, test-driven development, and powerful extensibility.\r\n\r\nAuthor Adam Freeman has thoroughly revised this market-leading book and explains how to get the most from ASP.NET Core for .NET 6. He starts with the nuts-and-bolts topics, teaching you about middleware components, built-in services, request model binding, and more. As you gain knowledge and confidence, he introduces increasingly more complex topics and advanced features, including endpoint routing and dependency injection. He goes in depth to give you the knowledge you need.\r\n\r\nThis book follows the same format and style as the popular previous editions but brings everything up to date for the new ASP.NET Core for .NET 6 release and broadens the focus to include all of the ASP.NET Core platform. You will appreciate the fully worked case study of a functioning ASP.NET Core application that you can use as a template for your own projects.", "OL5818599M", "/images/books/b907a2b2-c4f3-4233-aef4-a0c46098a6df.jpg", 264, 35.5m, "Pro ASP .NET Core 6" },
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

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "038e5319-0910-4cba-bf80-253a10030324" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "0908214c-eac6-4029-b303-8d987037c4ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "0e6103a7-8dae-4d2e-b438-74fe02768f4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "109044cd-44fb-470c-b7b9-2724987b08de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "1de2f067-3236-4b27-9fba-8b5d49db06ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "22657eba-f41a-4bb3-986e-83ef23fedf15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2708e501-67b2-4c5b-aacd-9a044df9de21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "283073f1-cc28-485a-ab58-44f4ed128264" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2b760fe4-01b3-4794-9d1a-a63002dc3ccd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "2c2467dc-c396-46ce-af79-da3e48398f4a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "33008499-b5d6-4dc4-8b90-81eb4c5da11e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "45538c3e-df96-4b79-86dc-e190def35cf4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "77eb1836-14d0-414d-85ad-3413afd9e2d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "7a09fc16-8d35-48e4-bf98-532a876423f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "838db25f-ef7e-4cda-aa56-dfe1691d298d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "87582ce2-32f8-48ac-a429-cdb22d49bd45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "8a702a88-26b5-4e9d-bd3e-6b088b350db5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "8d307bd3-3290-43c2-b9b3-eb2daf715cb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "93a879f7-64a2-4a8c-b821-a1304bd7c8fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "94280b80-6076-4025-9bf7-ae251fb7bcee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "978959e9-4ec5-49a0-a703-77884cc8d109" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "9a9b36f7-4a83-48c8-91d3-9136426dbee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a6424f60-c8e2-495d-bf48-bfb3e9457516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a6dc0238-4999-49e9-93c1-dfd243e36781" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "acb6d047-97c5-4553-82cf-d6042362af1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b87fc486-a805-4fad-89bd-c836281ce8a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "d966a121-573e-49ed-bf9b-5f677d0a4aa8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "f18ff312-2889-46df-a392-264b865a2c72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1353077-7dcd-4f94-820b-f8af8feb9690");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec3a92cc-8b64-4b83-bc6a-c20031faa327");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisteredOn",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: string.Empty,
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
