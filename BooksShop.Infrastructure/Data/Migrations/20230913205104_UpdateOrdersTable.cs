#nullable disable

namespace BooksShop.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ea05adbe-04ab-4e1a-887b-b3c748820969", "AQAAAAEAACcQAAAAEOLMBim7ZbTZbRxybLIIGpE5ANcJotUN1snOetjODIeP7mHvpbOML/7GxdwBdzewrw==", new DateTime(2023, 9, 13, 23, 51, 4, 70, DateTimeKind.Local).AddTicks(6785), "840de423-fae0-43d3-9527-3826be406d6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b36363af-c830-466b-b350-b0ef26a6c68f", "AQAAAAEAACcQAAAAEICA9kSOjdADpcdPneILrQoKVUH9Wl6mR+AKCoQFeL/w2yfK7bh3bbooE/c6iERrZA==", new DateTime(2023, 9, 13, 23, 51, 4, 46, DateTimeKind.Local).AddTicks(2142), "5bf95618-7f24-4fe8-870f-366b1c876cc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4e64959e-4a02-4c85-966f-866dbdc71f38", "AQAAAAEAACcQAAAAELBc/ob86B+pVcwFysf1QLAnr3RbEr/BvY4TdLWLLGTWbvFDe/HlMf5taeE2EFXiKQ==", new DateTime(2023, 9, 13, 23, 51, 4, 57, DateTimeKind.Local).AddTicks(3448), "d580da38-f4f5-4d38-9269-c96e288d0571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9c21fafa-8bd4-493e-8f76-144f3bfdb8b8", "AQAAAAEAACcQAAAAEIa0LxXZvI4tlK6ix+yhJCd3aINIft2ODymZOYNran8CCV9MIEKoZqb4HF3SW0dO7w==", new DateTime(2023, 9, 13, 23, 51, 4, 59, DateTimeKind.Local).AddTicks(5773), "1c3cf837-b157-4c4b-97e3-4741bbf07f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "61ff8e53-1120-45e3-9fdc-2734a1c7d46d", "AQAAAAEAACcQAAAAEDKSLN7T0sD9aRmT4ENAYJ95rk1IENraVdmWIY1iHrUpGM1KBLoMyCC2TZOYqHWFlQ==", new DateTime(2023, 9, 13, 23, 51, 4, 62, DateTimeKind.Local).AddTicks(9455), "90411e89-55e3-4719-a93a-50699e9e7612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e3f5bd03-5f64-4d04-877f-22e4e11f868c", "AQAAAAEAACcQAAAAEO0zWQt8wvk/nV1OIa9qY5aCh1+MgsQ5zO6wGX2sM3ZNYxP9t4yhJU9UQ2/bMHBogg==", new DateTime(2023, 9, 13, 23, 51, 4, 72, DateTimeKind.Local).AddTicks(8970), "5089ffbb-dbd0-4297-a4e4-f693f730a3fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2cef3a63-2545-4d88-9b9c-2c8dee82bf25", "AQAAAAEAACcQAAAAEIlyLM1/1TBrBwAVCO5YBFApkUk/p1jY4/ellolC85U5UUy+YNMv7KUEfPqI5VudLw==", new DateTime(2023, 9, 13, 23, 51, 4, 69, DateTimeKind.Local).AddTicks(5700), "17ea923e-9f1f-46ba-b94b-c12033e8eee7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1d4a4f05-9550-4768-b5b8-107382027154", "AQAAAAEAACcQAAAAEPjZ2TuDQ5OUWPL22JpqDAaMDju3eJAcHy0ejWsR5xckwzQMkKUcxL080cOmfT3qLQ==", new DateTime(2023, 9, 13, 23, 51, 4, 51, DateTimeKind.Local).AddTicks(7674), "e76df42e-a657-4a1f-afbc-1d2c5a0a5198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4b57451c-6f9b-4b6f-8c69-4db7e887066c", "AQAAAAEAACcQAAAAELPnwsY0RdCf/5qEsqoHkRhmrFvZnNuoKW1sVV5EhIIA9pPtGTxg+S1END0qbmaiQA==", new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5706), "715c7821-9aac-4fa0-be89-1d958a774869" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7b7f3e22-bee4-4117-b0cc-0a87eacce205", "AQAAAAEAACcQAAAAEH9f2drQ8tcHRzjzDPwBYrsoHGzdvkMBZTLxPav1KC3toO6QrChuggbYLo04OaHyTw==", new DateTime(2023, 9, 13, 23, 51, 4, 52, DateTimeKind.Local).AddTicks(8689), "109f605e-64b8-4f6e-8f6e-de5e90938ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ba8426ee-a985-41a5-8261-feda8aa37f76", "AQAAAAEAACcQAAAAEDMiyBUaO/iwv+c3Fa/DNvq4LqvhGBUo4L66YiQHJRRdD8BREQuvwSy07EDSB4Hmow==", new DateTime(2023, 9, 13, 23, 51, 4, 49, DateTimeKind.Local).AddTicks(5404), "92824891-534d-4383-a221-7ef27c1ecc7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4f097704-ff51-445a-9e04-a130cfd005ec", "AQAAAAEAACcQAAAAEOwBHofoPSECQWfK1XmjDoN4xWJC+Q2Bj5bHaHQk5vxlOsX951LqSvSmCvXgry2mgw==", new DateTime(2023, 9, 13, 23, 51, 4, 65, DateTimeKind.Local).AddTicks(1400), "b56e4e6f-790c-41e2-99f7-9deeab91f676" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f19756d3-d836-4a82-aa94-8842b4a57ab3", "AQAAAAEAACcQAAAAEMfAcSIgtd63mPFOIx7NpG8e2IzIsgyKEC1R8N6F02J5X6Zh/RDOpVxPLUJfqj4XeA==", new DateTime(2023, 9, 13, 23, 51, 4, 41, DateTimeKind.Local).AddTicks(8110), "8dc30ce4-5eb3-41e8-ab9a-447e91ab79cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "783ff57e-fd82-4b30-bb04-9929600f67d2", "AQAAAAEAACcQAAAAEP1rY3JjJj3oVb81yaEeFhBeUin8ny9gYrTmtoGEqlPB7btKjr6qQsR6h+MbvTLUQQ==", new DateTime(2023, 9, 13, 23, 51, 4, 47, DateTimeKind.Local).AddTicks(3305), "721b3f7b-e541-4974-9cfe-661b40be0631" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b97ac21a-da7e-4fa2-ae3a-31c7e5351353", "AQAAAAEAACcQAAAAEKNwCz4+IYozjP84ZJZG4sXoSYh6bIDKR/JbLB2+XemxaT4hkHt+F0+H/NJShfu3wQ==", new DateTime(2023, 9, 13, 23, 51, 4, 45, DateTimeKind.Local).AddTicks(1069), "765053a1-c936-4a3f-9ae3-b969087627b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "db4ec10a-effc-47e4-a8fc-1c3bab654705", "AQAAAAEAACcQAAAAEEHw+/f55sy5levaiJjJdGeEFaZjXvAthJOzfcuC1fG1LMUKaFvGqH927auUqCHz7g==", new DateTime(2023, 9, 13, 23, 51, 4, 68, DateTimeKind.Local).AddTicks(4642), "8196e81f-5eac-47ec-81ae-291710ed5b9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b13b7c0c-2e09-41d9-bef6-2a3541064343", "AQAAAAEAACcQAAAAENnyl/A6rL1d5aV2czmWFFGHwt7HXT096+J4pz7I4MNcUMRrskG07NDT6Wq9lJKfHw==", new DateTime(2023, 9, 13, 23, 51, 4, 50, DateTimeKind.Local).AddTicks(6580), "83c5c853-cfc5-4139-b7ec-0b095bc5ea2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "aa200537-e989-42d7-8a4e-d72d44637b1e", "AQAAAAEAACcQAAAAEEVdFRmrIIvo9pnNA1/aVz3xNNf3EirLT5eloukb+chhrPwdLT5nJv/EnEtcDiQzxA==", new DateTime(2023, 9, 13, 23, 51, 4, 66, DateTimeKind.Local).AddTicks(2431), "c3098202-bc37-4fc9-8282-17f2feee9551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "dcb78ceb-f964-4b7b-ba74-4397cb99085f", "AQAAAAEAACcQAAAAECRuGi6OCMTgkYW2M2usrx3OMZoFcvukAkyHwbb676z+0mjr+xr16k7X4/Wk8Az6qQ==", new DateTime(2023, 9, 13, 23, 51, 4, 44, DateTimeKind.Local).AddTicks(241), "3360e263-8a25-484c-9351-37fe626ce385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "23feb827-8374-4037-acee-de299d11c948", "AQAAAAEAACcQAAAAEHGWyREPpuQVWb0drZq6z4lEmu2+HMseEVxh1JJfDd9A3ONjVAWmQp9B29TThHkKXA==", new DateTime(2023, 9, 13, 23, 51, 4, 60, DateTimeKind.Local).AddTicks(7105), "2138731b-68e8-4516-a8e9-2774729f78ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5ad33a69-780d-4cb0-8c12-6082b70e6098", "AQAAAAEAACcQAAAAENSTulRnYu2GQO9lxWAZocdbO6RkS67OMUoVz+vojh0z29AH8nzdVS/4b8xGxljh5Q==", new DateTime(2023, 9, 13, 23, 51, 4, 58, DateTimeKind.Local).AddTicks(4580), "b15c6cc6-f9ef-4189-9951-76de8186b01d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "5382b68f-9488-4224-9f7f-59d36d1d7eab", "AQAAAAEAACcQAAAAEGYA4/e2BOOaB7QR1qQqs8u2WKPrMDDs5Dp9dkf1JvpFd/tlDlHbcmRZlUUHrTfuVQ==", new DateTime(2023, 9, 13, 23, 51, 4, 71, DateTimeKind.Local).AddTicks(7943), "f2e964e9-0d05-4830-ac40-b6ac24d7ad8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "27eea8a8-a5c6-4b81-a5bf-04a650a0a95d", "AQAAAAEAACcQAAAAEFCX3NchAKKZj12Y/VPVr6mtda2v3ScRrT2lZX7SvraQdL4wZC7MLHgaeLu+RD7DYw==", new DateTime(2023, 9, 13, 23, 51, 4, 40, DateTimeKind.Local).AddTicks(7042), "77f8f67e-8aac-41f9-b685-b3545d12f0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "53c381b3-363a-4df0-bb5d-97f9e973b180", "AQAAAAEAACcQAAAAEIRLQtWx9RRZHqSHZMB1lUMBeYGceIEapsLQDWK8ikaBYqqgoR6Th/fv9qjva77yZg==", new DateTime(2023, 9, 13, 23, 51, 4, 55, DateTimeKind.Local).AddTicks(1132), "0f7e804e-45ec-40e6-a974-0c8dd9f4a812" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e1986137-258a-49c4-acce-d079572e298a", "AQAAAAEAACcQAAAAEOZDOhlyqJenzu+3nKaofDGbIlDD17sryH2cWCK9Z2df4kr5AmEwpf0my4QwVdmkfA==", new DateTime(2023, 9, 13, 23, 51, 4, 67, DateTimeKind.Local).AddTicks(3621), "81106972-502a-453c-bb74-aa9aad1859f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1aa899fa-5d3a-45ad-85b9-8584e2d35b21", "AQAAAAEAACcQAAAAEG8li/oynx36lANjOObEZMdhaUCBORIFB5wJj/EuGQh4+DgcQLzQS3guKQvOtY7pfQ==", new DateTime(2023, 9, 13, 23, 51, 4, 42, DateTimeKind.Local).AddTicks(9168), "7f89d279-b143-4951-aa4a-0f583b1bc5ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "54ffd1a3-cf4a-4f58-bff5-f3d786d4f247", "AQAAAAEAACcQAAAAEBol2jWMr+jStu3vL63BWGfps5jZ3i/LHJdMqcelsk5NP+JFYEfWju0gVE0TayVaSw==", new DateTime(2023, 9, 13, 23, 51, 4, 53, DateTimeKind.Local).AddTicks(9970), "99e89cb5-3fcc-427a-bdfa-608eefff835d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "00d7b33f-4512-45a6-982b-9976ba130703", "AQAAAAEAACcQAAAAEO6G26+qNliAcRgDHjR9jeEvuZffFE67xrsDAAe66H4a8mgRgRjVYDIFRhGBjpzmDw==", new DateTime(2023, 9, 13, 23, 51, 4, 56, DateTimeKind.Local).AddTicks(2324), "7ab0ee20-50a2-4d26-bcbf-1809faed1909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d3d851b8-e256-461c-91d2-2b4cad04bf6f", "AQAAAAEAACcQAAAAEHxNIHzfBGSYaixp32ilHNzA5m18a0KMIAOPRaN1eslDuRLLH3L6O2gkXS6YF76/cA==", new DateTime(2023, 9, 13, 23, 51, 4, 64, DateTimeKind.Local).AddTicks(448), "a3410a1b-7991-4abd-9548-36bb548dd65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3787b3d7-8ea9-47d8-a070-2bbb8ba952c0", "AQAAAAEAACcQAAAAEJ1V6lOrL0TTD9J7MPN4SpQlVt3snnTzn9KXi1OfLmMQ43oK31mqM774UErB1tJErw==", new DateTime(2023, 9, 13, 23, 51, 4, 61, DateTimeKind.Local).AddTicks(8255), "c09cbe9d-257e-4552-ac3e-88ee10a144d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "df34b3b2-93ad-46b2-b740-c8b7092c3791", "AQAAAAEAACcQAAAAEO7vOo9em0y/OHu6GIinN1m6tuoB0k/XifzKT9/6nF2ybZ+mrWClJ8udHtaD4F+dEg==", new DateTime(2023, 9, 13, 23, 51, 4, 48, DateTimeKind.Local).AddTicks(4381), "a498aa0e-62af-4efb-b2bd-77940a4f89db" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 13, 23, 51, 4, 39, DateTimeKind.Local).AddTicks(5248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
