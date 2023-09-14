#nullable disable

namespace BooksShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class CreateOrdersAndBooksOrdersTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksOrders", x => new { x.BookId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_BooksOrders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ef9d00c4-b810-471e-91c9-999ecd359654", "AQAAAAEAACcQAAAAEA2kpUU4O/Ij/Q0JUbsf2dDEX0QN8vQduQXbJ+BVzF1IHNf8H5FZKb4FDp7P0KEIIw==", new DateTime(2023, 9, 14, 2, 59, 16, 348, DateTimeKind.Local).AddTicks(9972), "797ae408-eb14-4378-a907-87d41326ff63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "166e51dc-37fe-4000-95f5-4532adf592e6", "AQAAAAEAACcQAAAAEE73+bNUM9GfQB9PuJIBtUN5/LvP7J2SS6r8/iSvR3K6Zo+9rSp/4Bo8NvVbPvBjRw==", new DateTime(2023, 9, 14, 2, 59, 16, 324, DateTimeKind.Local).AddTicks(6748), "3b30016e-314e-4149-894f-39fddaa3f641" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a45b920e-439d-44f0-9d7b-949f1ede7628", "AQAAAAEAACcQAAAAEH3YZ30s7dKqI3h9kxVmPhWss6K71vM87saHqOnIoYlm2ivwUAP57E42bzkRLq5iTA==", new DateTime(2023, 9, 14, 2, 59, 16, 335, DateTimeKind.Local).AddTicks(6942), "e782a373-feeb-4e8a-b66c-139a2caf81fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "60613457-0762-4889-a3d8-bf5f2f077f02", "AQAAAAEAACcQAAAAEH/KbSFxz1k89X6OzQi8SO8F9ecm7TsW/3Icb6uIKDBRH0wHprIzEef88iYUXU4Bmw==", new DateTime(2023, 9, 14, 2, 59, 16, 337, DateTimeKind.Local).AddTicks(9022), "a7fb8f90-6595-4dcf-8eb1-76610c1bf800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7c5f0c0d-1518-4615-bb5c-32b513699680", "AQAAAAEAACcQAAAAEAGOZtStuCItS+ztrqZxGetqFEGImDqAAdI203d9q27VTLutBnU1kczTfA29Wk2WUw==", new DateTime(2023, 9, 14, 2, 59, 16, 341, DateTimeKind.Local).AddTicks(2201), "a7fe67ab-6543-40aa-9d52-e7cfff1b1335" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1ca2ad65-746a-456d-8315-60b2b3cdc9c3", "AQAAAAEAACcQAAAAEGT/s1zZ0dQrSvDvFXdheO4XDULHs74Uve1/Y/OEsaO41wh/fTmvECgnRcwsvaBIPg==", new DateTime(2023, 9, 14, 2, 59, 16, 351, DateTimeKind.Local).AddTicks(2037), "150810fc-19ee-42cd-ad00-4205d0f768bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2e35bf0b-2131-46af-93f7-49073fdef6d2", "AQAAAAEAACcQAAAAEENaljiAUWFMivTC4ebhnnELCIFgy9DN3HnkG6KSPGB6OWrgD3Rpm26Xo5OKG4FEmQ==", new DateTime(2023, 9, 14, 2, 59, 16, 347, DateTimeKind.Local).AddTicks(8923), "711b7b91-87b0-492b-9c7b-08a2a07dd5bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "c6ac6d94-bc67-4c75-9eb4-a039599d1abf", "AQAAAAEAACcQAAAAEDboZHHFvG32SN5ihhXYSIyEuOFItRwuh5gT7xk/ATT/jiiYz7dcCF5P3aThUq4LjA==", new DateTime(2023, 9, 14, 2, 59, 16, 330, DateTimeKind.Local).AddTicks(2036), "18f31958-38fd-432a-afe4-9490ca48c686" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "619c41ed-c255-4ffc-b286-c042562b2f50", "AQAAAAEAACcQAAAAEE9egjJittez4R3SzPuLuD+vkxBDqBh5GnFa6M7szfuOuASpxI5iYSfKL4WmwxcWAg==", new DateTime(2023, 9, 14, 2, 59, 16, 318, DateTimeKind.Local).AddTicks(318), "72e51687-ef58-40ab-abac-9998c36d14b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "78a205c4-bd97-4455-a6a4-2fd2cf08ade1", "AQAAAAEAACcQAAAAEJb0LEteB2unbbn8GwRSLoq3erWH7DNdn0pccxKSf7UVC8JaTEqxYCSNufGB8hzPmg==", new DateTime(2023, 9, 14, 2, 59, 16, 331, DateTimeKind.Local).AddTicks(3079), "1614d5e5-3063-45f3-9ebc-63c6bebd08db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2bae8a4c-547d-4b1a-ade4-7663eb9aaa16", "AQAAAAEAACcQAAAAEKDVF8noN976+csouqglYccCRbkPFMyec1Qy2ax487MH5i8vsej/9i8j3+2W+Ocwdw==", new DateTime(2023, 9, 14, 2, 59, 16, 327, DateTimeKind.Local).AddTicks(9775), "361019b8-cf0c-4f5a-994d-a3547ee5eeb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b3ec00aa-0ae2-4f1c-a4bd-873425f69e48", "AQAAAAEAACcQAAAAECAL426oeFse9414bhbQx+KFoFjkbDAN5Swr6FOvqs9eZPXtDYEpvXwkOdfAIh8X/w==", new DateTime(2023, 9, 14, 2, 59, 16, 343, DateTimeKind.Local).AddTicks(4369), "82b82156-ed13-4102-aded-9cbef359d269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "55137f16-39e7-4c04-bac7-6c9d7ea5dad5", "AQAAAAEAACcQAAAAEKxBxvxOTBqCtjNTJKyLzRzb9REvXwYamBno40TZDO9ugR3v5Ne7eBuA6AKkPaKnyA==", new DateTime(2023, 9, 14, 2, 59, 16, 320, DateTimeKind.Local).AddTicks(2519), "aecc6eb4-d3f1-44c5-9e0b-5c13784eb167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "17f81a32-31e5-4fc4-8973-006ca29f6a57", "AQAAAAEAACcQAAAAEGtnRt+wdOoQzuu+Q9KOA1S1lz7Duz0Mnd+DeA9IzFH22lMH+4+VWLkdXSBMvlUl0A==", new DateTime(2023, 9, 14, 2, 59, 16, 325, DateTimeKind.Local).AddTicks(7744), "8c9a82bf-7151-4462-a2be-4fb76b63c7a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "964f998e-e87c-45e7-b5a6-ed673c25eb19", "AQAAAAEAACcQAAAAEOwy0XQkOcKS5li+llOQalBJf5bk5uz2yaR2L7qnHE3PtrnWyDHVcM+Q2EZnDzv5WQ==", new DateTime(2023, 9, 14, 2, 59, 16, 323, DateTimeKind.Local).AddTicks(5705), "3a5f2e51-cc14-4e91-a904-6a25b53ba50f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "468db805-18ac-4f1c-88bd-fb04b51d76a4", "AQAAAAEAACcQAAAAECuWQegD953SyY73spqPme+twRUryelreVRIafeMC44oJSFwPYTKWCLa654mbENBAg==", new DateTime(2023, 9, 14, 2, 59, 16, 346, DateTimeKind.Local).AddTicks(7925), "82880a4e-3fc8-4e3d-9aa0-07c91b5ad93f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f0d8a2ca-0309-4f91-aa28-af03b1abd270", "AQAAAAEAACcQAAAAEAblKIUCEtF3Um+3xIuUfasFV7UbpUaGbb9QQxvwlf8FsfKEjoI/SJ4oqtfodopY2w==", new DateTime(2023, 9, 14, 2, 59, 16, 329, DateTimeKind.Local).AddTicks(765), "bcde38db-4c26-4f8d-b49b-f435c3602342" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7a0cad16-7471-49c7-a705-5be0064fb4d7", "AQAAAAEAACcQAAAAELO6GfdtbRkJfC1tBkbjgant3RBTZ1nyohtpJPgBN0dy+PAtRU9iyQBZB3TEyLlJ8Q==", new DateTime(2023, 9, 14, 2, 59, 16, 344, DateTimeKind.Local).AddTicks(5799), "056671a7-831b-4f07-9695-7f19bd259f2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f116955b-8df2-4f46-ae47-0c3d7519d962", "AQAAAAEAACcQAAAAECRe7wV4k+tV/0hVnDKS/F3xQSS6sSFnkgef5n81NJ5hn4XflN5lfG/iLgoJ9jKHbw==", new DateTime(2023, 9, 14, 2, 59, 16, 322, DateTimeKind.Local).AddTicks(4703), "36f3f96e-e51b-42ec-a66c-5c54fbded134" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9ed64f2d-0827-44c3-afc4-bfd418478b9b", "AQAAAAEAACcQAAAAEIUSFkrNGFeVWdv8vEaDa28LhhdJhs3ItcR+wF/CYlxjaVl/BEjQGMpxaR48GzAc7w==", new DateTime(2023, 9, 14, 2, 59, 16, 339, DateTimeKind.Local).AddTicks(206), "7d84b47a-cf64-4e60-bdb4-9dd270ec9712" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "893accdf-a60f-4238-97b7-8ea4694ab520", "AQAAAAEAACcQAAAAEKA8cFNzqXDXUegRMEtDw5QyauKlZQaukqVyDPpDwnlWGfzRwyA25D5S3gWOdLRjBA==", new DateTime(2023, 9, 14, 2, 59, 16, 336, DateTimeKind.Local).AddTicks(7963), "ea34f40d-5201-41a9-9b3c-5d9d5832dee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "04c47070-46c6-4377-a6c4-d8904e53f10b", "AQAAAAEAACcQAAAAELCs8mcWTjcJ+q/pvwb+iz8F6ejRE+yoe8gla7fGjjz7xk3dTSP21kE1xJwVVWIFYA==", new DateTime(2023, 9, 14, 2, 59, 16, 350, DateTimeKind.Local).AddTicks(1081), "6aaa91c2-9a59-40af-8619-3730b9bfee66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "161ba4e8-645e-41fd-b3d7-19283db1445f", "AQAAAAEAACcQAAAAEAybsnkIkyvGh5syZLWu9ABcJpPpwubH0vyQcbooWm9mBl8Sw2WGK9alubFFePQSvQ==", new DateTime(2023, 9, 14, 2, 59, 16, 319, DateTimeKind.Local).AddTicks(1583), "2b66af5f-dd3d-4e3e-a4ce-f069c54287ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "31a4186c-c630-4a90-b368-dbd4541fcdae", "AQAAAAEAACcQAAAAEJaKhsrEnJfH94ORrRvQV7ZPl2vg0ciQ+m+I1jHkh9KOMwHWDNplERBaFY1M6YVtGg==", new DateTime(2023, 9, 14, 2, 59, 16, 333, DateTimeKind.Local).AddTicks(4947), "1eb68782-d7cb-4b81-9415-24b1f1a5fc11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "0636dc5e-1ae3-4c56-b72d-404f45ea6bde", "AQAAAAEAACcQAAAAEOOfArdMIgfkJFu4+uoyYgDJF7IZOjDU8e63zmjUr9in7xVY3iFSL4UK9tDpD9Pagw==", new DateTime(2023, 9, 14, 2, 59, 16, 345, DateTimeKind.Local).AddTicks(6827), "2b79787b-37d2-41cd-a5de-2530ad350568" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1fd1d508-ce87-4ed1-ad89-1829ba7fd42e", "AQAAAAEAACcQAAAAEEUiDHcMuhIjzh1pCCtmr9+9QU20BkMMke4Wa37PxHf+zxMm8j2PC/mTz5ENp12W/Q==", new DateTime(2023, 9, 14, 2, 59, 16, 321, DateTimeKind.Local).AddTicks(3587), "629fd4f8-4324-460d-8736-7fe383ea9b9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b8e5f674-5a1d-4980-831e-68cab8f0fa4c", "AQAAAAEAACcQAAAAEIbxq8oP02GHrpuO4BOAhrn5zoSPCdlTkc11cRYSNzObDcAjuNhTskOpXy3q/kIQ2w==", new DateTime(2023, 9, 14, 2, 59, 16, 332, DateTimeKind.Local).AddTicks(3923), "94393c93-0f05-4687-81b0-a3b930ac8db5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "378b9064-528e-4161-a848-8e0968ff6f0b", "AQAAAAEAACcQAAAAEGVNudaN4AQdyQr7O5aZDHQeuw8XSGZntRC3hCIKdbXY+i0e20uOnThGe6hbsu7b7g==", new DateTime(2023, 9, 14, 2, 59, 16, 334, DateTimeKind.Local).AddTicks(5979), "9679d784-9a82-47e7-b5da-d6e2c98f8831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "08c7a5b2-6be3-4a00-8966-0ef9ade50d2b", "AQAAAAEAACcQAAAAEP/UlNXOYKhK1COup5kHw179WYZxy6WUkrc8XU37STyfrjomzV6hB4x3qiWBzaKwgw==", new DateTime(2023, 9, 14, 2, 59, 16, 342, DateTimeKind.Local).AddTicks(3347), "27db81ee-33ff-4015-a671-5a08b0cbb258" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d1029766-6b48-4c96-bfa8-d27c90165ae6", "AQAAAAEAACcQAAAAEMayp4EtunQtLNvejw+fjRQ7PkNqqFqUWDFFR38XhaZkcy8tWGby6ifsWO47k4q4zw==", new DateTime(2023, 9, 14, 2, 59, 16, 340, DateTimeKind.Local).AddTicks(1235), "e974fc00-7330-4ac1-b997-c5324c45f89a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a00e3aa7-9297-441b-86af-1ffa3983b227", "AQAAAAEAACcQAAAAECQSK84b9Lse+eeBfA9+eRDIb7iAjlf7yjjBmPiCu1lGdl8fD0uVKEgtj+AlpHLT2g==", new DateTime(2023, 9, 14, 2, 59, 16, 326, DateTimeKind.Local).AddTicks(8838), "bb060f5d-23c3-4c92-909f-7a6820d4fec3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 14, 2, 59, 16, 317, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.CreateIndex(
                name: "IX_BooksOrders_OrderId",
                table: "BooksOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "55fd1855-b9d5-44f9-85e2-93d5418762bd", "AQAAAAEAACcQAAAAEOZsRj2snTkJs9TB0b1Z2YJkHi39ZlKHX3YOKTqBwqWW3PXLVuaw7ov87sft1N6DxQ==", new DateTime(2023, 9, 9, 16, 54, 26, 696, DateTimeKind.Local).AddTicks(2760), "9a991dfd-1d0e-4e4a-8ec1-3d2560f3b564" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "bdba2eda-b0c4-43d7-bcd9-e6e569aa0e69", "AQAAAAEAACcQAAAAEIEM3KrhFFL4jV5wyyKL3NXCX9L5ccyPqzPrOgDM2nRuUGnEtYK4/yo3wITIGS9Thw==", new DateTime(2023, 9, 9, 16, 54, 26, 671, DateTimeKind.Local).AddTicks(8254), "d4020c10-0734-49a4-9b52-a3d89f0fc88d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7eacb3c2-9b5c-4caf-8e83-8ed7c666cb1f", "AQAAAAEAACcQAAAAECeceMf6Lwe6jUkOoNUtPAh7NF10AheMSYCPi9isIyu26b0hs4n2t04sG8kFsTOe/A==", new DateTime(2023, 9, 9, 16, 54, 26, 682, DateTimeKind.Local).AddTicks(9009), "6d66bd38-70a7-45a9-b03a-95a96cf4ba2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "51f79f83-0656-4153-9087-4062d292bdcb", "AQAAAAEAACcQAAAAEOY4FcVmRMo0yKc3/VaIpjE2I9HT8PHsXtN9Topx333ZTU61NOx3HBZxLn7zQ/BGCQ==", new DateTime(2023, 9, 9, 16, 54, 26, 685, DateTimeKind.Local).AddTicks(1320), "6c760a4c-9c89-4db3-96a4-7b93681a6444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "497f7eb5-ae47-457b-ad27-534481c0b5ab", "AQAAAAEAACcQAAAAEBONdZoBs+iiVCH3SmLlIEoc8W7Ac5RXQqRSxYHdADT3uzWeFcIYwkYUhKxyZJOnkQ==", new DateTime(2023, 9, 9, 16, 54, 26, 688, DateTimeKind.Local).AddTicks(4745), "6e909c79-a9ab-4215-a77e-927ded74fe65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "c5a59c8b-9580-4684-85a7-c9c2c59156d0", "AQAAAAEAACcQAAAAEGxXMdiuLYzG1hd52srZALjeE4IFZgH5ecXVaTwy2u0xzDGG44nNz2f5P2pXYCz0OQ==", new DateTime(2023, 9, 9, 16, 54, 26, 698, DateTimeKind.Local).AddTicks(5263), "ad09c3f8-cf97-4931-ab5a-9c97ac966285" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "21d6014e-30e2-4813-b9ed-a273fa045c27", "AQAAAAEAACcQAAAAELiRwyh4+CahnRi2wJNbbM5I2nCxzaB7uoDR3qPSRDHnoGom+1umg50qIbzmckCWfw==", new DateTime(2023, 9, 9, 16, 54, 26, 695, DateTimeKind.Local).AddTicks(1704), "c5cdc1a0-2604-4db9-9403-d2ac7f1f88e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "721a752c-1c14-4e65-9895-0fd710b6698e", "AQAAAAEAACcQAAAAEK45+lPInfxVscXV0r4MvjRGixUnJYtYQN4WpIRXpSgXbDhXy/XAVTDdjXJYnSdrXw==", new DateTime(2023, 9, 9, 16, 54, 26, 677, DateTimeKind.Local).AddTicks(3559), "c3494dee-703c-4e8f-9c58-b4aa1c3a7a01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3f6d0564-a78e-434e-babf-c6974544ad48", "AQAAAAEAACcQAAAAEOCpmbZoq84MJzAa482nwHXvkmqc8po/uf/h0oGrRv+eEAvpW2sA8bwNbgq/NfK0xQ==", new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1456), "26ee4080-b76a-45f1-b358-2ce4e9a6d04e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "966fa100-b284-463e-8a80-783261c1f221", "AQAAAAEAACcQAAAAEKr6C+A3Srl3ystzyJlhKqMzYyrPvmfPSh4gLOgl1Sv4Nwr1klaU/4f0ctNHn1MR8g==", new DateTime(2023, 9, 9, 16, 54, 26, 678, DateTimeKind.Local).AddTicks(4684), "de5d6623-daae-4896-b3eb-b803c7ad801e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "061c0dc3-7f45-4c89-b84b-85cc2bf98264", "AQAAAAEAACcQAAAAEC8W7wgztPNVP/5A3htFu52EwJ8NWcWc/qbSG6aLaztK3RhRsyqnUkgf61E7e5yzOg==", new DateTime(2023, 9, 9, 16, 54, 26, 675, DateTimeKind.Local).AddTicks(1351), "7634d611-3feb-4e61-b064-57f53f8d6699" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a6ea409c-700e-4a86-a591-1abbac0d7b8b", "AQAAAAEAACcQAAAAENux76qwkq8BIIl0n/7I0FGS23iAaDxpJ+sxOw+b9lzbtgeG1mDwx7dHqLfhbpzZTw==", new DateTime(2023, 9, 9, 16, 54, 26, 690, DateTimeKind.Local).AddTicks(7085), "c924f152-4cc5-4b12-81da-11b316687992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7a0cc94b-5d76-4b1a-bf28-fc3ae429682c", "AQAAAAEAACcQAAAAEDm3nYpvET7EMMCVNJTuuAS0x5S6fAEof8gtI6wcekheFCfO54kByRnduNGCov9+zQ==", new DateTime(2023, 9, 9, 16, 54, 26, 667, DateTimeKind.Local).AddTicks(3779), "3b076ecf-b803-4cac-be45-6f9da1305e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "82e1c373-3fe2-4680-90fe-6235425b5546", "AQAAAAEAACcQAAAAEGWO4EyDZS4jaZ3on8mT5wasVdVGEntBTzxiWnf5Cgh/z4zeE465m7hCDeFjN90OtQ==", new DateTime(2023, 9, 9, 16, 54, 26, 672, DateTimeKind.Local).AddTicks(9279), "395cb9c0-381e-4a02-adcf-7c4ead064904" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9e9787af-84c9-47f6-aa0c-22e5c30866bc", "AQAAAAEAACcQAAAAEPT0WFI7NRWJBQoT9Sru4Ef+L/mCkENStNo7fxpCe/0A61AcpQKVZlkuZSfKIVzc2w==", new DateTime(2023, 9, 9, 16, 54, 26, 670, DateTimeKind.Local).AddTicks(7193), "80a067a4-3e74-42cc-8f30-94ede13a0c70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "563c07f5-dbb0-4175-9563-46313715a73f", "AQAAAAEAACcQAAAAEGSbmzdnWQ5hTL8mse9GvOHUzN9fYzjGNZaj/VpxhAycmkaD9TO3v/nTPLGa1DZ+Kg==", new DateTime(2023, 9, 9, 16, 54, 26, 694, DateTimeKind.Local).AddTicks(764), "fbc818ba-5aea-4fbf-aec1-47ed2137f96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d76d7b04-4e0a-4c38-b018-97416a49c5cb", "AQAAAAEAACcQAAAAEB/PlJu/FI58+mDlYYXLgWPLC0tqtjaQng0GEBwYGdWcFvhnBzdBA4t96DWoxNsL9Q==", new DateTime(2023, 9, 9, 16, 54, 26, 676, DateTimeKind.Local).AddTicks(2360), "6371d6ae-53d9-49dd-9590-480ce222d285" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a948b9f1-da2e-47fe-9a23-20965992b2bd", "AQAAAAEAACcQAAAAEOuoJSrSQILEFVzF7UQXlsX7TK3N038vKmwB/Q7d4MoH9DzYXnbk29soHL/DRNa+dA==", new DateTime(2023, 9, 9, 16, 54, 26, 691, DateTimeKind.Local).AddTicks(8403), "f20ad080-e736-4b21-bd74-f1c65ab9c420" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "67035692-80c3-4891-9028-5a9f69867c83", "AQAAAAEAACcQAAAAEKy5OSymd23/nF5UgG36IK4m0KvQTcUUrP3hXsfLIFxWr5ZLShxbnt1cViR5yTuv2g==", new DateTime(2023, 9, 9, 16, 54, 26, 669, DateTimeKind.Local).AddTicks(6095), "195f913e-ece7-44d2-9919-962e7ba41044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f7207d96-d37c-4d14-a446-491bf78be2d7", "AQAAAAEAACcQAAAAEGL2yTEct5+EezzYYM8f6+YaqUF7QXaYQ/HTAmTmOva+ERwANVIqDFm5OScJWZdyrQ==", new DateTime(2023, 9, 9, 16, 54, 26, 686, DateTimeKind.Local).AddTicks(2555), "63ad0050-cd99-4c4a-a47a-06f11cde9cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "472110aa-70fa-4fb2-8aa5-588bda15b4d2", "AQAAAAEAACcQAAAAEDmdzjRpFsGhf32+JJWHT/E1cty42xuPbhqThv5A0ed07nJ3IRdmr7IBIXc48H0cpQ==", new DateTime(2023, 9, 9, 16, 54, 26, 684, DateTimeKind.Local).AddTicks(200), "2cd96590-ae21-4dc7-aced-1cd62b27ed93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "8961dbd1-eb4c-4d6b-b349-1ed87d96a59f", "AQAAAAEAACcQAAAAEDnL6DhSythdtYNzCymqBYEuRODYM+063bsO0vAxpk838Z6Zja+IxLjPW1Lyr1Yqng==", new DateTime(2023, 9, 9, 16, 54, 26, 697, DateTimeKind.Local).AddTicks(4058), "8f6b7426-4d67-4cd6-a847-6b6d259fcff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5f05c4ae-000c-4c80-aa55-4cf578609694", "AQAAAAEAACcQAAAAECAhS8x5AN7EkVU+ToO8/EiCv+QmrnHnwHTe0zsj1EntDFml3dq6duvP+AnO3IXYYQ==", new DateTime(2023, 9, 9, 16, 54, 26, 666, DateTimeKind.Local).AddTicks(2691), "c250c03c-a612-4339-8993-bae444e5f08b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "dbd70afc-9e76-4eb4-942a-81e4d7846c2c", "AQAAAAEAACcQAAAAELpQAlezlRYipml/cG1x9oa2aGYNzR9RXmBW3O/LKRvP793xwNaNxd4G/8o5j06DQg==", new DateTime(2023, 9, 9, 16, 54, 26, 680, DateTimeKind.Local).AddTicks(6964), "76054070-2877-4dd6-aa2f-fe98535dd717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "55baeb01-76d5-433e-8e9b-ffc9cadbfaaf", "AQAAAAEAACcQAAAAEPPKeUkQIKvdIIaxI8ek4K/TcYQuK5FG3g7ngLcrnAfW6Vd4Xnc1kI4giJo57CbRrg==", new DateTime(2023, 9, 9, 16, 54, 26, 692, DateTimeKind.Local).AddTicks(9446), "e683feb9-9bf0-403f-aa94-1da911433d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "31f92fec-8b94-4464-9228-2bfa247db327", "AQAAAAEAACcQAAAAEOxX03XzCQpZZnB8tBF2ciOKIfIRgCLV55XBd+QAwpdZcqzqqTFY+pRPCgyBPI3jzg==", new DateTime(2023, 9, 9, 16, 54, 26, 668, DateTimeKind.Local).AddTicks(4802), "859dbd0b-3db4-49d8-ad08-032bfa8f0b8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "307316d3-e729-4e6b-9d0e-7e61d2a6dae5", "AQAAAAEAACcQAAAAEANNpHPlZ7pxEquLdkFVXkCzq1XWGWngrsJOU9WP6xlG3tSxkVk8iaEU0PHj0UunSA==", new DateTime(2023, 9, 9, 16, 54, 26, 679, DateTimeKind.Local).AddTicks(5918), "3aedfb99-e864-432b-9586-bbb531218240" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a1adb9d1-10bd-4b45-94dd-f482e7bea5e7", "AQAAAAEAACcQAAAAEKTvUpo9bYqWKM9zOKLYeFsYhJBy19XdFSS+DOAzIfkuy3sBBpWpWCGSz+hB4XbaCQ==", new DateTime(2023, 9, 9, 16, 54, 26, 681, DateTimeKind.Local).AddTicks(7870), "db974193-e887-4922-8dee-e5e944374b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "62e69d37-0ae5-4be7-a481-019c554f97eb", "AQAAAAEAACcQAAAAECNVRx7Ll9540TT/tc+Bdy0pOW8+IEpThNM2KZ7tBiwIx9trJTUn6iQvEJKkqOFEOw==", new DateTime(2023, 9, 9, 16, 54, 26, 689, DateTimeKind.Local).AddTicks(5855), "4b9c8d83-cd4b-4151-8662-ac6ad8285aac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5f9eea8c-a73f-4732-ab96-906fe5d44ecb", "AQAAAAEAACcQAAAAELWuL0pCa3/BmXxHyv0Ez9aXvmFueSZmwXwE/nb9+80099ecfkQGmz0ulrMY2GgwgQ==", new DateTime(2023, 9, 9, 16, 54, 26, 687, DateTimeKind.Local).AddTicks(3567), "a25406a7-8e6c-4040-ace4-2d77aa7a5579" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ec954236-d9ca-4ad8-aaf9-e72ac41e0d4c", "AQAAAAEAACcQAAAAED1PU4W6K81+Hx0ig0y7RaAscx5Uuhruq7K+PYIat4szCkzLMheb6R0oM5PWF+2fsg==", new DateTime(2023, 9, 9, 16, 54, 26, 674, DateTimeKind.Local).AddTicks(350), "71bf3ef3-9bc9-4075-9796-1c78578ce144" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 9, 16, 54, 26, 665, DateTimeKind.Local).AddTicks(1072));
        }
    }
}
