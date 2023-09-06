#nullable disable

namespace BooksShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UsersAndRolesConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "283073f1-cc28-485a-ab58-44f4ed128264", 0, "Izgrev block 41, Bourgas 8000, Bulgaria", "b4219209-9d86-4cc2-b057-43f8e90ee157", "admin@gmail.com", true, "Iva", "Sabotinova", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBAZfAThmipgnh2k7DfH4mUq1psLIIygaxvVsYz34G4xhceF0Jkgh93XSQ+SLC+i0g==", null, false, new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3502), "01e07df9-1f57-4d7c-b8ec-d641ef041b1b", false, "admin" },
                    { "9a9b36f7-4a83-48c8-91d3-9136426dbee9", 0, "Slaveykov block 33, Bourgas 8000, Bulgaria", "c2bf69cb-88c6-4392-bbf8-03bfe22ad3f2", "client@gmail.com", true, "Pesho", "Martinov", false, null, "CLIENT@GMAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAECPsLfCg1wLh8QUR9scTI09+1t+tF+6F7u173FRMVusmA2dISwKSMZzsEJBXLL/zdQ==", null, false, new DateTime(2023, 9, 6, 10, 40, 0, 55, DateTimeKind.Local).AddTicks(5079), "52ba16ed-02f4-4439-9fba-fc1d43787d14", false, "client" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 6, 10, 40, 0, 54, DateTimeKind.Local).AddTicks(3119));

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 2, 20, 12, 54, 537, DateTimeKind.Local).AddTicks(8920));
        }
    }
}
