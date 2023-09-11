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
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                values: new object[] { "e4eefa68-55a6-4412-8ad6-b1a5da683d4e", "AQAAAAEAACcQAAAAECbGL+JbvRzocNYegAMDqfy+AZq2p0Phbv0VP1SzG+xjSiy3U+2KZOznWps6Yb/Sew==", new DateTime(2023, 9, 11, 0, 26, 34, 961, DateTimeKind.Local).AddTicks(7165), "6dd5d605-9c8c-498e-b72b-b304999e01c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "434cc680-dbcb-4d64-9cee-8fa7cc9ff055", "AQAAAAEAACcQAAAAEJJeV0EnYzHjemTRxmQp4/XDSKvpajmctYbc0mkelAQBg9tB6D6Gml0sK+mmXvfkJg==", new DateTime(2023, 9, 11, 0, 26, 34, 937, DateTimeKind.Local).AddTicks(3035), "1cd49ff7-eea6-4ee4-8e3f-19c586dbc290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "db7ed91e-b39b-4a25-a68c-837181d9bb31", "AQAAAAEAACcQAAAAEDD5J6gZOf/SkUnN+/1C4IJsizi3Fo0BRGsBBebOeY4nVYN0oKMRn3V7kQCHsU1sSQ==", new DateTime(2023, 9, 11, 0, 26, 34, 948, DateTimeKind.Local).AddTicks(3377), "47da6c03-3892-48a9-b023-07180b0cca48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4cd2a346-4725-4ce5-96b9-e4b7032ebacf", "AQAAAAEAACcQAAAAEAemHd/bHetFwly5otPwmdyidk3Dna57BIwnRe0408LJbR+y3OJMqrdH3sYpgahT1g==", new DateTime(2023, 9, 11, 0, 26, 34, 950, DateTimeKind.Local).AddTicks(5566), "e3122bf0-7553-4820-b03f-9af79c93d2e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1626ed59-c7f6-4d3e-a241-7ca5fd928605", "AQAAAAEAACcQAAAAEK5/RwlbEsC8rSpht4rYhCNfYE5Vwg/3U6LZKNdxTAZGao9qv4VWlWVcQr+LNqRFLg==", new DateTime(2023, 9, 11, 0, 26, 34, 953, DateTimeKind.Local).AddTicks(8931), "2db2bec0-6c10-485c-ab89-d51623aacb2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b86b114b-8229-454a-b87b-84b8150d2601", "AQAAAAEAACcQAAAAEMdfrEmelXmVrouRQO+uMMLLnIkUUpqGz842gPoOSSldDRXpJD5YLaCAF+rIJiutoQ==", new DateTime(2023, 9, 11, 0, 26, 34, 963, DateTimeKind.Local).AddTicks(9300), "3df16aa7-d5c5-45b7-a387-a47f27fabc22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9417d5eb-9644-4b9e-96b0-2ac530f8f511", "AQAAAAEAACcQAAAAEFg6e2YcNFY3HnCxOK0rDTwwabTyv/szePCnGGwkEaVHx0F7Tk7ZNEAGcif2nmeFiw==", new DateTime(2023, 9, 11, 0, 26, 34, 960, DateTimeKind.Local).AddTicks(5629), "f820be38-f061-49ff-b605-73315572883b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6fd63e31-5a5d-484d-a9b2-1bc737ca8230", "AQAAAAEAACcQAAAAENJZDs/yFjOnUnGoW3bYYyosJQgNRsNGNH6nedldW75kKdZHeYhP2DO9Id5cMECEow==", new DateTime(2023, 9, 11, 0, 26, 34, 942, DateTimeKind.Local).AddTicks(8703), "551c2807-8c4e-4c98-9cd8-6855fe93838a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ee37eddc-82bd-4884-8e59-9c204a1edd91", "AQAAAAEAACcQAAAAENaHxXynzcpdyMjRitByvSHci5xqZvXXl5gCst0EpVj8F9OqsTBxybnx8flNBTwf4A==", new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6490), "11384ff6-3586-4535-bf38-01871e515a4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "db30fa5f-ee10-469c-b929-9045fd77d781", "AQAAAAEAACcQAAAAEIPC/ByaeHbxGWLly2ei2JRxnkTnYXfE1UeWzQn4KjZDQVPfpPG0xkA9kfGFobjviw==", new DateTime(2023, 9, 11, 0, 26, 34, 943, DateTimeKind.Local).AddTicks(9657), "effe33fa-0bbf-43b2-8793-80e6f272c134" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9c61906f-955e-4693-9025-a5b2f1673ec0", "AQAAAAEAACcQAAAAEMMM6fiRCyohAuUSI2GJZWNrPNiRSflqw1NR2iB+qDz7bVAofW+lFJBGAckrxly1vw==", new DateTime(2023, 9, 11, 0, 26, 34, 940, DateTimeKind.Local).AddTicks(6233), "2f44413b-b639-498f-8289-2169c69440a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5592e54f-b6ec-4693-92dc-a846b502c429", "AQAAAAEAACcQAAAAEPmFQox5z2FEeVbrL8HvpZrPhYskUsy/TUboNCIow3mW1SY1w7Zeid63Z41qfRuAiw==", new DateTime(2023, 9, 11, 0, 26, 34, 956, DateTimeKind.Local).AddTicks(1232), "3cd0782f-e643-4d21-a606-20e64edd02ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5e1163cd-f113-44b1-84e5-5e765b052f17", "AQAAAAEAACcQAAAAEMLGg01vR21w7mpteYmP1pDOvOBO2eruUaoVx7Z3VHmlSvtDd/VSC3w4l6G1zo0ULA==", new DateTime(2023, 9, 11, 0, 26, 34, 932, DateTimeKind.Local).AddTicks(9157), "73e0b6a3-c391-4633-8875-b8cae17ad239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d30fffb0-f8ff-420e-b42a-a9ed7ec9242f", "AQAAAAEAACcQAAAAECy0OGfuDdhFzFT4bJxBZS4pAIXPrGl3iib68HXEN5wIKUEK/6VPUwuCf093C30PVA==", new DateTime(2023, 9, 11, 0, 26, 34, 938, DateTimeKind.Local).AddTicks(4056), "c9d215e9-e6fb-4fee-bc08-c5faca6223ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ceb3a1ba-49f5-4e41-81a2-6b8b235437de", "AQAAAAEAACcQAAAAEHChM2dfgyzbmeTVS3aAZKaSOysfpGIqnlYvhTQOXKyk+FU+qJiw5ljzz2qhkWWeEA==", new DateTime(2023, 9, 11, 0, 26, 34, 936, DateTimeKind.Local).AddTicks(2010), "bf56f957-96c5-46de-96fb-c8f4dba83ef3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "de51538e-4d69-4f8f-b009-dff89c17948b", "AQAAAAEAACcQAAAAEMmB0K5B3jgAPxXp1ts6bg7/E0j70AwlzWmFI6jgCH9KiyKiHf/aXrjuUu1NNMoRMQ==", new DateTime(2023, 9, 11, 0, 26, 34, 959, DateTimeKind.Local).AddTicks(4517), "0ad21149-a594-4751-af85-d1fa498ef605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "af9e7b76-e02f-483e-9db2-7f27ee58fdf9", "AQAAAAEAACcQAAAAEOxBQLiblwj2LRDHKhDshYCoLbwTv7LkHPIyl/qhbeZ9mXPanKps5O/D0xlR7v/vLg==", new DateTime(2023, 9, 11, 0, 26, 34, 941, DateTimeKind.Local).AddTicks(7365), "0ce8f975-1e68-4f0c-bb48-9348eb8a4dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "df483f76-990f-44f5-81b4-bcd4f5cbde35", "AQAAAAEAACcQAAAAEHlNH7DkVzw3jRDFH1d3YSQSroXMceAmssoIgW7KTYo7n+3ii2kcGc/FrnXfgSsiYg==", new DateTime(2023, 9, 11, 0, 26, 34, 957, DateTimeKind.Local).AddTicks(2613), "c034f6ab-8d36-4ffc-b220-236a170edf60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9922ae2a-0769-40ab-8a52-573925ee952d", "AQAAAAEAACcQAAAAEGSqbIlzWB0hnAqk/Pb1TsjUB0hr0tkA1+GF6O6yqsh4Hc4/Qt69z4T6CQGsGIedCQ==", new DateTime(2023, 9, 11, 0, 26, 34, 935, DateTimeKind.Local).AddTicks(1072), "1efb9464-e4d6-4d73-90c1-af05865941e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f26907d1-62c2-4f42-ac00-15cc3d237e10", "AQAAAAEAACcQAAAAELISG98Qe3Hy5DXRHAKm6ippwopXQ1i7252Oln8oLnwjQzsgjPms/gDYM65wCR7JIQ==", new DateTime(2023, 9, 11, 0, 26, 34, 951, DateTimeKind.Local).AddTicks(6611), "fdb71d9a-86e4-4cde-9818-4470b10a0e8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "731fd22c-04c4-4c89-9711-8e62fb48109b", "AQAAAAEAACcQAAAAEK1Tau+RENmizThU3q+cSiY3v6hI0JrsuXq8+9M4l6l8a+XnaB+8eLUV4XFR48h7pQ==", new DateTime(2023, 9, 11, 0, 26, 34, 949, DateTimeKind.Local).AddTicks(4411), "a7dd6d10-cd2c-45c8-b978-757e1e95519d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "40222960-332b-430b-bc67-b8d79ec4c301", "AQAAAAEAACcQAAAAEAig5mg1lUeCJdTRYXg0IIKqaBWzJm+nAg5KkAQoLFm5gs/jgw6Bw9qkIWLZuzyRGQ==", new DateTime(2023, 9, 11, 0, 26, 34, 962, DateTimeKind.Local).AddTicks(8158), "b0d0d101-1faf-42bc-8fb3-afd85917510e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "fd87eafd-2463-475c-8c2d-4bcbc94dedc8", "AQAAAAEAACcQAAAAEJxRSDCWB4ualfYhnC2jX274wMklGpPehsXj6ey7hT1ySOLqaPKgmxZ6Jce+auxlEQ==", new DateTime(2023, 9, 11, 0, 26, 34, 931, DateTimeKind.Local).AddTicks(7827), "ad33b313-1826-4b16-8027-6c614c28ad8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a692e9a8-e0d9-4f52-8080-9a600a145028", "AQAAAAEAACcQAAAAEN87uSW7k2rwib245oi7kXEw7BaTNHyu2sU2hM5Ujbzf1P+LL1L9PqyF8KN65qdTgw==", new DateTime(2023, 9, 11, 0, 26, 34, 946, DateTimeKind.Local).AddTicks(1487), "dd2f77f8-151c-4b97-be0e-d17ba8ad2639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "bd9f499c-4021-43eb-9184-6c2d61723ba2", "AQAAAAEAACcQAAAAEH69/VNOzX4+J5wpvoGLv/Mjd+SqgkP94OZ3G51j2IJPQis4Vcwwmkf4dtCmuPdWdQ==", new DateTime(2023, 9, 11, 0, 26, 34, 958, DateTimeKind.Local).AddTicks(3516), "03571630-18de-4bac-86b2-ed3a95794492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6d926154-3560-4d59-b1dd-bfab1a9cf670", "AQAAAAEAACcQAAAAEJRq9a+eoNCeQ2kUivh/pIWFGNlI57iF/QDSD1tGmrrdnQDCi3XWgfBlGoVp+81SUg==", new DateTime(2023, 9, 11, 0, 26, 34, 934, DateTimeKind.Local).AddTicks(55), "88ebc20f-deed-471d-9e67-ef12acd662bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5e41a7e1-1c00-4ea3-8d4b-564e36e2d843", "AQAAAAEAACcQAAAAELFTs7NJdG8dQ0E0bIKIYkU0fBBRHJ0L4v93NsBoiD4+kpyNyIOLL/i88DGD8vutTg==", new DateTime(2023, 9, 11, 0, 26, 34, 945, DateTimeKind.Local).AddTicks(518), "2f4b97dd-654a-4b4e-b52c-3903239d4004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1e0354a1-2f55-4674-82ab-a03a7429f6ff", "AQAAAAEAACcQAAAAEJRG8jgDFC9ExF+q9y5iYKj0SLoGkQCv4TUaHLRHQu+Ul8ueenEEpL/tbKsLxWKjXg==", new DateTime(2023, 9, 11, 0, 26, 34, 947, DateTimeKind.Local).AddTicks(2449), "93d1d1d7-1855-464a-81b5-be8dd9ceb2ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5cbc4589-6b74-4a54-84c9-550c89ff0640", "AQAAAAEAACcQAAAAEHNNzUNL5smS4H+npUE0JvDpB7BlImIW1HkBBKf+tEHqzLwB0Ga0pAnRrFFOA+SF6g==", new DateTime(2023, 9, 11, 0, 26, 34, 955, DateTimeKind.Local).AddTicks(238), "ebe5926e-5644-42b5-a066-1b4a44acb1b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f8120f7f-10f6-4328-b943-d991872fa80b", "AQAAAAEAACcQAAAAEK8wxVUnAgQONg6c9L3kRwEogF4OxC6ygdd088QFIpG9y5p9yhdpv7RUfsmWzPoJVg==", new DateTime(2023, 9, 11, 0, 26, 34, 952, DateTimeKind.Local).AddTicks(7698), "0d044634-e1b9-4c5f-b3d8-19ec8aa52827" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "dc06ea2a-669e-495d-9733-921577a3b26a", "AQAAAAEAACcQAAAAEPVgUi+QtGJqScsVFZRyVlnG2U36uJ+ZBxP5qy4Sxdg+0Z84egjvkpciWDaYMYkA8A==", new DateTime(2023, 9, 11, 0, 26, 34, 939, DateTimeKind.Local).AddTicks(5229), "f6e2bd7e-2452-409a-a73d-17b17d385cf8" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 11, 0, 26, 34, 930, DateTimeKind.Local).AddTicks(6026));

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
