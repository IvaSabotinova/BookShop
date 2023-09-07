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
                    { "038e5319-0910-4cba-bf80-253a10030324", 0, "Lazur Quarter block 13, Bourgas 8000, Bulgaria", "3b82ff2b-0720-47b4-95b9-5f0c59f88f11", "dinko@abv.bg", true, "Dinko", "Martinov", false, null, "DINKO@ABV.BG", "DINKO", "AQAAAAEAACcQAAAAELnsMEhkqQiG5oAcCJizMkfVHakqb0KxqeJpm3iMQYmue1HjpEG+d+BoLWxVIWHFZQ==", "+359888124578", false, new DateTime(2023, 9, 7, 19, 26, 23, 268, DateTimeKind.Local).AddTicks(5690), "9d4f2876-a9f8-4c4c-96b4-66e9b28342cf", false, "Dinko" },
                    { "0908214c-eac6-4029-b303-8d987037c4ad", 0, "Primorski Blvd 7, Varna 9000, Bulgaria", "bfa9d95a-7b53-4f82-b8b3-a261f4daad2f", "martin@abv.bg", true, "Martin", "Martinov", false, null, "MARTIN@ABV.BG", "MARTIN123", "AQAAAAEAACcQAAAAEJNqLAcNFPMGVcfv7Bldpr2bw1f3P2iwh4/Knew7zE85ru/jPQx0AdQ6wNsM3iwB7w==", "+359898554554", false, new DateTime(2023, 9, 7, 19, 26, 23, 243, DateTimeKind.Local).AddTicks(8583), "ebf74ae6-4167-448b-a378-535e346a9b04", false, "Martin123" },
                    { "0e6103a7-8dae-4d2e-b438-74fe02768f4f", 0, "Izgrev Quarter block 6, Bourgas 8000, Bulgaria", "4e67fa3d-db46-4ea0-b149-1d4d7bb497b3", "stanislav@abv.bg", true, "Stanislav", "Georgiev", false, null, "STANISLAV@ABV.BG", "STANISLAV", "AQAAAAEAACcQAAAAEDR76QcitG3BrO49MvTm07bJqsGc4G1B1hrMHseN2aSyKFSz4kNLR1sWPCA4alCnYA==", "+359877711771", false, new DateTime(2023, 9, 7, 19, 26, 23, 255, DateTimeKind.Local).AddTicks(792), "886009c1-bf7d-4546-916c-9e26a024dafa", false, "Stanislav" },
                    { "109044cd-44fb-470c-b7b9-2724987b08de", 0, "Lazur Quarter block 80, Bourgas 8000, Bulgaria", "416821d0-3d17-4c7e-bf0c-535a995afdb5", "yovko@abv.bg", true, "Yovko", "Ivov", false, null, "YOVKO@ABV.BG", "YOVKO", "AQAAAAEAACcQAAAAEBohm8NlXPLQepEXCR0ZDJtmSYr63ID4+yMPv3fYCqck656Xh5w8GeNGgBvcjBY/fQ==", "+359876262626", false, new DateTime(2023, 9, 7, 19, 26, 23, 257, DateTimeKind.Local).AddTicks(3325), "6a943390-cd90-4491-8600-1c5d0c4b335f", false, "Yovko" },
                    { "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca", 0, "Slaveykov Quarter block 20, Bourgas 8000, Bulgaria", "c35642c0-9059-4556-abde-5a8390c56f76", "boyan@abv.bg", true, "Boyan", "Atanasov", false, null, "BOYAN@ABV.BG", "BOYAN", "AQAAAAEAACcQAAAAEB0U5FH7JFiuPXcvOb7rCpuiuLAhVK5wbBGQsCBbQG54mAxC/uDNfeyhJ6wqrWqIDA==", "+359877742247", false, new DateTime(2023, 9, 7, 19, 26, 23, 260, DateTimeKind.Local).AddTicks(7121), "c9e893c3-9522-486e-95a5-4da55d9c003a", false, "Boyan" },
                    { "1de2f067-3236-4b27-9fba-8b5d49db06ae", 0, "Slaveykov Quarter block 68, Bourgas 8000, Bulgaria", "76a0c9ae-39c0-48a0-a0f7-371a50bf935e", "dimitar@abv.bg", true, "Dimitar", "Dimitrov", false, null, "DIMITAR@ABV.BG", "DIMITAR", "AQAAAAEAACcQAAAAEL3gjqvC9nGfam9p8hqUoAxcAd9ChWOw3Lg6Vej1VsdftdNvzm1fxb6uCTRJzVNqfQ==", "+359888181818", false, new DateTime(2023, 9, 7, 19, 26, 23, 270, DateTimeKind.Local).AddTicks(8281), "c4dfc9a5-4cb1-4d73-a30a-c98d0941b99f", false, "Dimitar" },
                    { "22657eba-f41a-4bb3-986e-83ef23fedf15", 0, "Vl. Varnenchik block 14, Varna 9000, Bulgaria", "7ad89874-5f1e-457b-bdbf-f74a220aebe7", "lyuben@abv.bg", true, "Lyuben", "Nikolov", false, null, "LYUBEN@ABV.BG", "LYUBEN", "AQAAAAEAACcQAAAAECTzhBz578X+tG1i+BMmAM3oEqGM2g86NsjupOiEGK4ufQzgLxI3JNZOTjsJGHDFmQ==", "+359897357357", false, new DateTime(2023, 9, 7, 19, 26, 23, 267, DateTimeKind.Local).AddTicks(4267), "6555bbfd-42bf-45a2-affe-8b7c17acdb21", false, "Lyuben" },
                    { "2708e501-67b2-4c5b-aacd-9a044df9de21", 0, "Slaveykov block 31, Bourgas 8000, Bulgaria", "2b10066c-949a-468e-8c4b-86366ab064cf", "atanas@abv.bg", true, "Atanas", "Mitev", false, null, "ATANAS@ABV.BG", "ATANAS", "AQAAAAEAACcQAAAAEKico08Rd159jQCB9ZTAKOVQsTJnl56lXXL6Ymf7C/+65De8kuIU/AfzDv8wIo2EDA==", "+359899313131", false, new DateTime(2023, 9, 7, 19, 26, 23, 249, DateTimeKind.Local).AddTicks(4254), "2ff1e3cd-8386-444f-8ead-abd4b93174f2", false, "Atanas" },
                    { "283073f1-cc28-485a-ab58-44f4ed128264", 0, "Izgrev block 41, Bourgas 8000, Bulgaria", "2c6c5db2-9585-4d50-8966-5b54c135f709", "admin@gmail.com", true, "Iva", "Sabotinova", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAECAiCMgrP3l1jz7A0JuHtEvIkDtMfrDXnoOyIAwkp7/k38+FBe/Xfh0YsB4Oc1+ATw==", "+359889694030", false, new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8632), "4e85416a-1066-4237-808f-d772234c76d2", false, "admin" },
                    { "2b760fe4-01b3-4794-9d1a-a63002dc3ccd", 0, "Izgrev Quarter block 29, Bourgas 8000, Bulgaria", "53a5fa4a-541f-4625-b163-4b23997f22b8", "simona@abv.bg", true, "Simona", "Georgieva", false, null, "SIMONA@ABV.BG", "SIMONA", "AQAAAAEAACcQAAAAEAnv6gayeivjZkpwrXY0qBOEqelSZJQui/JE7/aekRzShuwp5baV51b16NoGlNGXlQ==", "+359888333333", false, new DateTime(2023, 9, 7, 19, 26, 23, 250, DateTimeKind.Local).AddTicks(5441), "e16cdc13-76f6-4db7-ac15-5cf41434d8f9", false, "Simona" },
                    { "2c2467dc-c396-46ce-af79-da3e48398f4a", 0, "Vazrazhdane Quarter block 70, Bourgas 8000, Bulgaria", "7aa647f4-dc24-4719-9337-b39f5ca66e13", "rayko@abv.bg", true, "Rayko", "Yasenov", false, null, "RAYKO@ABV.BG", "RAYKO", "AQAAAAEAACcQAAAAEAy3Lbc4eYAsibv9157yfRyaTJ6VWr1I6vg8xsCU0Q28/NGaiobLcIwMmfHXqurCdg==", "+359888658974", false, new DateTime(2023, 9, 7, 19, 26, 23, 247, DateTimeKind.Local).AddTicks(1852), "32718718-f794-4650-aa82-339168ae3e83", false, "Rayko" },
                    { "33008499-b5d6-4dc4-8b90-81eb4c5da11e", 0, "Hr. Boteb Blvd block 5, Bourgas 8000, Bulgaria", "9e4b052b-9802-444a-8314-9ef021013700", "genadi@abv.bg", true, "Genadi", "Atanasov", false, null, "GENADI@ABV.BG", "GENADI", "AQAAAAEAACcQAAAAEPZ9TsBGz85q2EnKQjqDe57ZB/3jtF5SUTKMZ6nR9Tte9wYiLpQ06FISTNJbTJ7W7w==", "+359899369369", false, new DateTime(2023, 9, 7, 19, 26, 23, 262, DateTimeKind.Local).AddTicks(9518), "b3bb23ee-6801-49f7-9fbb-0cba884f710e", false, "Genadi" },
                    { "45538c3e-df96-4b79-86dc-e190def35cf4", 0, "Lazur block 33, Bourgas 8000, Bulgaria", "a6fdd75c-4c5b-457b-85f4-09931f5a5128", "gosho@gmail.com", true, "Gosho", "Goshev", false, null, "GOSHO@GMAIL.COM", "GOSHO", "AQAAAAEAACcQAAAAEHEWiRbwl2pRMfcDodVwB2CfjQUJMXSMmYvSNZItjgPdQ3HwiyghIMBGvvEMIAo6sA==", "+359877111111", false, new DateTime(2023, 9, 7, 19, 26, 23, 239, DateTimeKind.Local).AddTicks(3257), "76709fcb-7200-4380-886a-b2b300cc40c0", false, "Gosho" },
                    { "77eb1836-14d0-414d-85ad-3413afd9e2d9", 0, "Stefan Stambolov Blvd 8, Bourgas 8000, Bulgaria", "b00f8ef5-0000-4b5b-bcc1-58bcd387f37f", "valeri@abv.bg", true, "Valeri", "Yovkov", false, null, "VALERI@ABV.BG", "VALERI", "AQAAAAEAACcQAAAAEBeNgYozpM3P6EC4voJkEfh4h8PGMv3uaq7uQuhuxL/7AojUst0YVAWI/BQPGfzbWQ==", "+359888121210", false, new DateTime(2023, 9, 7, 19, 26, 23, 244, DateTimeKind.Local).AddTicks(9729), "c59cee6c-8571-4f3e-b005-e15c05fe2725", false, "Valeri" },
                    { "7a09fc16-8d35-48e4-bf98-532a876423f2", 0, "Vl.Varnenchik block 8, Varna 9000, Bulgaria", "a429aa5f-c55f-4efe-b1fe-e7da15a3966e", "nikola80@abv.bg", true, "Nikola", "Petrov", false, null, "NIKOLA80@ABV.BG", "NIKOLA", "AQAAAAEAACcQAAAAED3m5LkGKihrqNF+dxkITy6htMH7uYjWgSoLMIag2jkLV2VBeVzSsNdKV6T98pmnBw==", "+359899555555", false, new DateTime(2023, 9, 7, 19, 26, 23, 242, DateTimeKind.Local).AddTicks(7405), "39a41f40-c129-469f-8c1b-e6d05c585006", false, "Nikola" },
                    { "838db25f-ef7e-4cda-aa56-dfe1691d298d", 0, "Mara Gidik Street block 4, Bourgas 8000, Bulgaria", "e4f681c6-892a-48b5-8921-d49e8cbba8de", "desislav@abv.bg", true, "Desislav", "Stoyanov", false, null, "DESISLAV@ABV.BG", "DESISLAV", "AQAAAAEAACcQAAAAEIWBa+nBVbYLwEfefBoj7T3P/nvTuSfCE1W3u7ppglJcaJYbwp02WYEr6rbL3eRMYg==", "+359899949596", false, new DateTime(2023, 9, 7, 19, 26, 23, 266, DateTimeKind.Local).AddTicks(3264), "f506bf20-bd63-43bf-bc13-473cbe10e3b5", false, "Desislav" },
                    { "87582ce2-32f8-48ac-a429-cdb22d49bd45", 0, "Vazrazhdane Quarter block 71, Bourgas 8000, Bulgaria", "c2b17802-7be9-4352-bc38-d29ff924a9c6", "yasen@abv.bg", true, "Yasen", "Ivanov", false, null, "YASEN@ABV.BG", "YASEN", "AQAAAAEAACcQAAAAEJ271G3wcONzimRFDkobIuQRhjIio/M3TcngL5aS/YnUeRnZxVOWBANEk3p3pivAGQ==", "+359888656565", false, new DateTime(2023, 9, 7, 19, 26, 23, 248, DateTimeKind.Local).AddTicks(3030), "470feb4d-45c2-47a0-b54f-3080dfd62db8", false, "Yasen" },
                    { "8a702a88-26b5-4e9d-bd3e-6b088b350db5", 0, "Hr. Boteb Blvd block 2, Bourgas 8000, Bulgaria", "c7daffc6-c692-4b51-a7ea-4de5e669f7ca", "dragomir@abv.bg", true, "Dragomir", "Martinov", false, null, "DRAGOMIR@ABV.BG", "DRAGOMIR", "AQAAAAEAACcQAAAAEH2MBTFK6rXgLQqY0J/rzyXdrJ8QdbzsZBL0mbFdyRwgWLxh/somBitM71v3qRyajg==", "+359888258258", false, new DateTime(2023, 9, 7, 19, 26, 23, 264, DateTimeKind.Local).AddTicks(775), "34d34e83-555e-4d3d-b6cd-e3db0e4d153d", false, "Dragomir" },
                    { "8d307bd3-3290-43c2-b9b3-eb2daf715cb4", 0, "Vl.Varnenchik block 50, Varna 9000, Bulgaria", "314f061d-0c50-4e27-8d5f-72ee19ba0ed2", "mara@abv.bg", true, "Mara", "Petrova", false, null, "MARA@ABV.BG", "MARA", "AQAAAAEAACcQAAAAEFfQA3U9FU27ls36w4fv2KA9KTzzOHhubhr6d/RWxc014Iq83e90v9orbWZc/0ygvA==", "+359888556556", false, new DateTime(2023, 9, 7, 19, 26, 23, 241, DateTimeKind.Local).AddTicks(6230), "118e4502-74d3-4935-a287-2dacc88ffd29", false, "Mara001" },
                    { "93a879f7-64a2-4a8c-b821-a1304bd7c8fb", 0, "Vazrazhdane Quarter block 50, Bourgas 8000, Bulgaria", "fae138ff-c7f4-4bb0-b3c5-d9e8b0f383f4", "yovka@abv.bg", true, "Yovka", "Yasenova", false, null, "YOVKA@ABV.BG", "YOVKA", "AQAAAAEAACcQAAAAEBFASDJ/bZ9k7TGoRShwCaIar9xd+r8CVbRjnvYmcNYkTSUmtD9pVHAmyGdN9l3vDg==", "+359998919119", false, new DateTime(2023, 9, 7, 19, 26, 23, 258, DateTimeKind.Local).AddTicks(4517), "19145ff2-fa0a-4141-a2bf-87fdb3e7671e", false, "Yovka" },
                    { "94280b80-6076-4025-9bf7-ae251fb7bcee", 0, "Izgrev Quarter block 22, Bourgas 8000, Bulgaria", "44a3035f-504d-4bcd-bb75-68ddfa57df61", "stanislava@abv.bg", true, "Stanislava", "Ivanova", false, null, "STANISLAVA@ABV.BG", "STANISLAVA", "AQAAAAEAACcQAAAAEGX96JgEVYAdB2KN46QFfBp5SrLHRYud+O1wldjb7lqWc4Zk2GLaUIqy3Z2/fSy6cg==", "+359889126543", false, new DateTime(2023, 9, 7, 19, 26, 23, 256, DateTimeKind.Local).AddTicks(2090), "c45a142b-79a7-47ab-b3e7-756dab92bc50", false, "Stanislava" },
                    { "978959e9-4ec5-49a0-a703-77884cc8d109", 0, "Lazur Quarter block 16, Bourgas 8000, Bulgaria", "c24321a4-39bf-4e4d-9f86-ef72d7bfb14c", "katerina@abv.bg", true, "Katerina", "Markova", false, null, "KATERINA@ABV.BG", "KATERINA", "AQAAAAEAACcQAAAAEJPsaiT9zFHssqgfQjCcJuPFiwriTYaX47QgjXxAMdswfZkPpca82/CeVLfmc9co6g==", "+359888951847", false, new DateTime(2023, 9, 7, 19, 26, 23, 269, DateTimeKind.Local).AddTicks(6915), "ab4d9786-d522-429a-9488-382ae16a42a9", false, "Katerina" },
                    { "9a9b36f7-4a83-48c8-91d3-9136426dbee9", 0, "Slaveykov block 33, Bourgas 8000, Bulgaria", "9a5c6ffd-235e-4946-aa3a-c9c980f783af", "client@gmail.com", true, "Pesho", "Martinov", false, null, "CLIENT@GMAIL.COM", "CLIENT", "AQAAAAEAACcQAAAAEKqCo7mePzKVEx+BTaNq0C6j853lCwHaKcVq+2FJuCP6N8QAgaiwMnpyGXduJfnVfw==", "+359877222222", false, new DateTime(2023, 9, 7, 19, 26, 23, 238, DateTimeKind.Local).AddTicks(127), "0fbb496a-504b-461f-994a-68057d221d25", false, "client" },
                    { "a6424f60-c8e2-495d-bf48-bfb3e9457516", 0, "Mara Gidik street 18, Bourgas 8000, Bulgaria", "f3ca2747-42c0-4993-b54a-b224f710963e", "daniel@abv.bg", true, "Daniel", "Vladislavov", false, null, "DANIEL@ABV.BG", "DANIEL", "AQAAAAEAACcQAAAAEOqAhUPLnxCqNK7OzHbDHGkOxJF1eWLNa2/AQTN8THLGOkI6mbrg4h3vQzTB7b5rSQ==", "+359899919100", false, new DateTime(2023, 9, 7, 19, 26, 23, 252, DateTimeKind.Local).AddTicks(7945), "04fb792f-a318-46d7-ba3b-0fa2df4e3b62", false, "Daniel" },
                    { "a6dc0238-4999-49e9-93c1-dfd243e36781", 0, "Mara Gidik Street block 8, Bourgas 8000, Bulgaria", "f206d3a4-73f6-4f72-a330-0239a5ca4a4b", "ilian@abv.bg", true, "Ilian", "Stoyanov", false, null, "ILIAN@ABV.BG", "ILIAN", "AQAAAAEAACcQAAAAEBBrel2sNVmpYYSfTTS8//nk1oXxY3xgINHQL/JuW02PkcH2El5XJpFc7Uyt6b8aaA==", "+359888654789", false, new DateTime(2023, 9, 7, 19, 26, 23, 265, DateTimeKind.Local).AddTicks(2090), "03a10633-5b85-4157-9956-c23774cc8a75", false, "Ilian" },
                    { "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b", 0, "Troikata Square block 1, Bourgas 8000, Bulgaria", "9289c087-9638-4607-b618-4b2eefdf25a0", "vlado20@abv.bg", true, "Vlado", "Ivanov", false, null, "VLADO20@ABV.BG", "VLADO20", "AQAAAAEAACcQAAAAEFOJDlnIlCrcnTEnEe/reuIsQUQlE1IA/zSnQsvZm4TMvil7SwnBuMSdgKyK3qfQ9g==", "+359877334334", false, new DateTime(2023, 9, 7, 19, 26, 23, 240, DateTimeKind.Local).AddTicks(4983), "ffbeeb8d-2ebd-4138-813f-b95fc79a5428", false, "Vlado20" },
                    { "acb6d047-97c5-4553-82cf-d6042362af1e", 0, "Mara Gidik street 29, Bourgas 8000, Bulgaria", "f891fefa-7aa2-4a01-835d-960063a7000a", "denislav@abv.bg", true, "Denislav", "Georgiev", false, null, "DENISLAV@ABV.BG", "DENISLAV", "AQAAAAEAACcQAAAAELLFJt470spyQfxLSJK7uv2n1uaWVb5cOWEJOgUnVMJlDyi751mNnzUSZAnB9MKr1A==", "+359888010101", false, new DateTime(2023, 9, 7, 19, 26, 23, 251, DateTimeKind.Local).AddTicks(6625), "9da660ed-92a4-447b-a8a1-729ee1831a39", false, "Denislav" },
                    { "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc", 0, "Gladstone street block 6, Bourgas 8000, Bulgaria", "b5aded9d-c4f2-40c9-86e8-d5e6f9ea9f6d", "daniela@abv.bg", true, "Daniela", "Ivanova", false, null, "DANIELA@ABV.BG", "DANIELA", "AQAAAAEAACcQAAAAEKVVoz3XR6pexZV8Vu9m8Lu/aKr0l0V1njBn8n8Y6HGbjutH2AX11D0MPBom41rR0A==", "+359888030330", false, new DateTime(2023, 9, 7, 19, 26, 23, 253, DateTimeKind.Local).AddTicks(9444), "af04e039-dbff-423c-8a0e-533ec2306cfa", false, "Daniela" },
                    { "b87fc486-a805-4fad-89bd-c836281ce8a0", 0, "Slaveykov Quarter block 17, Bourgas 8000, Bulgaria", "29003763-614b-4510-8d82-e3a1759a7b84", "boyana@abv.bg", true, "Boyana", "Marinova", false, null, "BOYANA@ABV.BG", "BOYANA", "AQAAAAEAACcQAAAAELpSnDzcqY+qpj+3MFSHMLmzL9fm/dp/3gu8Zi00S/+sQ+KWZxv9HuNWVQaun+q3Ug==", "+359888159159", false, new DateTime(2023, 9, 7, 19, 26, 23, 261, DateTimeKind.Local).AddTicks(8203), "4b2d00a6-b6e8-4d99-87cd-cf456274a7e1", false, "Boyana" },
                    { "d966a121-573e-49ed-bf9b-5f677d0a4aa8", 0, "Vazrazhdane Quarter block 49, Bourgas 8000, Bulgaria", "1c425a15-d7d5-4dad-900b-caa9ea25f26c", "boiko@abv.bg", true, "Boiko", "Asenov", false, null, "BOIKO@ABV.BG", "BOIKO", "AQAAAAEAACcQAAAAEFS+c4oh0DFvJ0hLyEqXyvJXtbCNfhDguIblgbO1IApWL2Pz81EFYcNze+wyCNHfjQ==", "+359888147147", false, new DateTime(2023, 9, 7, 19, 26, 23, 259, DateTimeKind.Local).AddTicks(5823), "eed398a2-0e13-4a73-b913-82e2428a80fb", false, "Boiko" },
                    { "f18ff312-2889-46df-a392-264b865a2c72", 0, "Hr. Botev Blvd 85, Bourgas 8000, Bulgaria", "b9aa5fe7-0599-481a-81ba-b58615384f2f", "gogo@abv.bg", true, "Gogo", "Goshev", false, null, "GOGO@ABV.BG", "GOGO", "AQAAAAEAACcQAAAAECiv7BW2uB+7pAxIge7ef6ZGOAKjc/lNR2OwAR1WYHLq5WXk2amZl3JZbdXHlnnHhw==", "+359898331456", false, new DateTime(2023, 9, 7, 19, 26, 23, 246, DateTimeKind.Local).AddTicks(769), "7eaa4e34-9bc7-4bd2-8bc3-866cd7acc832", false, "Gogo" },
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 7, 19, 26, 23, 236, DateTimeKind.Local).AddTicks(8301));

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
                    { "b1353077-7dcd-4f94-820b-f8af8feb9690", "f18ff312-2889-46df-a392-264b865a2c72" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
