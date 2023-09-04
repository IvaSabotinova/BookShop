#nullable disable

namespace BooksShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UserAndRoleConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "b2e26a49-1cd2-47b3-ba2b-2211e7d851e6", "Client", "CLIENT" },
                    { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "6610b899-c6bf-4036-9831-ad602745c824", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredOn", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "283073f1-cc28-485a-ab58-44f4ed128264", 0, "Izgrev block 41, Bourgas 8000, Bulgaria", "71190574-dc75-4756-87dc-98d54c9c0122", "admin@gmail.com", true, "Iva", "Sabotinova", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEqOux4peqG6cjDlXHk4ZnCGWJhDCpPmi1vlNZHHDWlOc1Yv+fWzXVguAleWRNNyqg==", null, false, new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5480), null, false, "admin" },
                    { "9a9b36f7-4a83-48c8-91d3-9136426dbee9", 0, "Slaveykov block 33, Bourgas 8000, Bulgaria", "f7f6cb7d-0dd5-4bd2-9a3d-d6659b866057", "client@gmail.com", true, "Pesho", "Martinov", false, null, "CLIENT@GMAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAEKw5g63iBVKbJrRGZppQYH+mezVMZgcmoiOlBki9bal2lhqfELVbWP8aIrH/kRZGrg==", null, false, new DateTime(2023, 9, 4, 23, 59, 12, 444, DateTimeKind.Local).AddTicks(7640), null, false, "client" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 23, 59, 12, 443, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "283073f1-cc28-485a-ab58-44f4ed128264" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "9a9b36f7-4a83-48c8-91d3-9136426dbee9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec3a92cc-8b64-4b83-bc6a-c20031faa327", "283073f1-cc28-485a-ab58-44f4ed128264" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1353077-7dcd-4f94-820b-f8af8feb9690", "9a9b36f7-4a83-48c8-91d3-9136426dbee9" });

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
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 4, 20, 51, 26, 452, DateTimeKind.Local).AddTicks(6710));
        }
    }
}
