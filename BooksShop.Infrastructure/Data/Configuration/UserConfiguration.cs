namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
             builder.HasData(this.CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser admin = new ApplicationUser()
            {
                Id = "283073f1-cc28-485a-ab58-44f4ed128264",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = "+359889694030",
                EmailConfirmed = true,
                FirstName = "Iva",
                LastName = "Sabotinova",
                Address = "Izgrev block 41, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            admin.PasswordHash = hasher.HashPassword(admin, "admin123456");
            users.Add(admin);

            ApplicationUser client01 = new ApplicationUser()
            {
                Id = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                UserName = "client",
                NormalizedUserName = "CLIENT",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "client@gmail.com",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                PhoneNumber = "+359877222222",
                EmailConfirmed = true,
                FirstName = "Pesho",
                LastName = "Martinov",
                Address = "Slaveykov block 33, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client01.PasswordHash = hasher.HashPassword(client01, "client123456");
            users.Add(client01);

            ApplicationUser client02 = new ApplicationUser()
            {
                Id = "45538c3e-df96-4b79-86dc-e190def35cf4",
                UserName = "Gosho",
                NormalizedUserName = "GOSHO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "gosho@gmail.com",
                NormalizedEmail = "GOSHO@GMAIL.COM",
                PhoneNumber = "+359877111111",
                EmailConfirmed = true,
                FirstName = "Gosho",
                LastName = "Goshev",
                Address = "Lazur block 33, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client02.PasswordHash = hasher.HashPassword(client02, "gosho123456");
            users.Add(client02);

            ApplicationUser client03 = new ApplicationUser()
            {
                Id = "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                UserName = "Vlado20",
                NormalizedUserName = "VLADO20",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "vlado20@abv.bg",
                NormalizedEmail = "VLADO20@ABV.BG",
                PhoneNumber = "+359877334334",
                EmailConfirmed = true,
                FirstName = "Vlado",
                LastName = "Ivanov",
                Address = "Troikata Square block 1, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client03.PasswordHash = hasher.HashPassword(client03, "vlado123456");
            users.Add(client03);

            ApplicationUser client04 = new ApplicationUser()
            {
                Id = "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                UserName = "Mara001",
                NormalizedUserName = "MARA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "mara@abv.bg",
                NormalizedEmail = "MARA@ABV.BG",
                PhoneNumber = "+359888556556",
                EmailConfirmed = true,
                FirstName = "Mara",
                LastName = "Petrova",
                Address = "Vl.Varnenchik block 50, Varna 9000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client04.PasswordHash = hasher.HashPassword(client04, "mara123456");
            users.Add(client04);

            ApplicationUser client05 = new ApplicationUser()
            {
               Id = "7a09fc16-8d35-48e4-bf98-532a876423f2",
               UserName = "Nikola",
               NormalizedUserName = "NIKOLA",
               SecurityStamp = Guid.NewGuid().ToString(),
               Email = "nikola80@abv.bg",
               NormalizedEmail = "NIKOLA80@ABV.BG",
               PhoneNumber = "+359899555555",
               EmailConfirmed = true,
               FirstName = "Nikola",
               LastName = "Petrov",
               Address = "Vl.Varnenchik block 8, Varna 9000, Bulgaria",
               RegisteredOn = DateTime.Now,
            };

            client05.PasswordHash = hasher.HashPassword(client05, "nikola123456");
            users.Add(client05);

            ApplicationUser client06 = new ApplicationUser()
            {
               Id = "0908214c-eac6-4029-b303-8d987037c4ad",
               UserName = "Martin123",
               NormalizedUserName = "MARTIN123",
               SecurityStamp = Guid.NewGuid().ToString(),
               Email = "martin@abv.bg",
               NormalizedEmail = "MARTIN@ABV.BG",
               PhoneNumber = "+359898554554",
               EmailConfirmed = true,
               FirstName = "Martin",
               LastName = "Martinov",
               Address = "Primorski Blvd 7, Varna 9000, Bulgaria",
               RegisteredOn = DateTime.Now,
            };

            client06.PasswordHash = hasher.HashPassword(client06, "martin123456");
            users.Add(client06);

            ApplicationUser client07 = new ApplicationUser()
            {
                Id = "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                UserName = "Valeri",
                NormalizedUserName = "VALERI",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "valeri@abv.bg",
                NormalizedEmail = "VALERI@ABV.BG",
                PhoneNumber = "+359888121210",
                EmailConfirmed = true,
                FirstName = "Valeri",
                LastName = "Yovkov",
                Address = "Stefan Stambolov Blvd 8, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client07.PasswordHash = hasher.HashPassword(client07, "valeri123456");
            users.Add(client07);

            ApplicationUser client08 = new ApplicationUser()
            {
                Id = "f18ff312-2889-46df-a392-264b865a2c72",
                UserName = "Gogo",
                NormalizedUserName = "GOGO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "gogo@abv.bg",
                NormalizedEmail = "GOGO@ABV.BG",
                PhoneNumber = "+359898331456",
                EmailConfirmed = true,
                FirstName = "Gogo",
                LastName = "Goshev",
                Address = "Hr. Botev Blvd 85, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client08.PasswordHash = hasher.HashPassword(client08, "gogo123456");
            users.Add(client08);

            ApplicationUser client09 = new ApplicationUser()
            {
                Id = "2c2467dc-c396-46ce-af79-da3e48398f4a",
                UserName = "Rayko",
                NormalizedUserName = "RAYKO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "rayko@abv.bg",
                NormalizedEmail = "RAYKO@ABV.BG",
                PhoneNumber = "+359888658974",
                EmailConfirmed = true,
                FirstName = "Rayko",
                LastName = "Yasenov",
                Address = "Vazrazhdane Quarter block 70, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client09.PasswordHash = hasher.HashPassword(client09, "rayko123456");
            users.Add(client09);

            ApplicationUser client10 = new ApplicationUser()
            {
                Id = "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                UserName = "Yasen",
                NormalizedUserName = "YASEN",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "yasen@abv.bg",
                NormalizedEmail = "YASEN@ABV.BG",
                PhoneNumber = "+359888656565",
                EmailConfirmed = true,
                FirstName = "Yasen",
                LastName = "Ivanov",
                Address = "Vazrazhdane Quarter block 71, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client10.PasswordHash = hasher.HashPassword(client10, "yasen123456");
            users.Add(client10);

            ApplicationUser client11 = new ApplicationUser()
            {
                Id = "2708e501-67b2-4c5b-aacd-9a044df9de21",
                UserName = "Atanas",
                NormalizedUserName = "ATANAS",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "atanas@abv.bg",
                NormalizedEmail = "ATANAS@ABV.BG",
                PhoneNumber = "+359899313131",
                EmailConfirmed = true,
                FirstName = "Atanas",
                LastName = "Mitev",
                Address = "Slaveykov block 31, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client11.PasswordHash = hasher.HashPassword(client11, "atanas123456");
            users.Add(client11);

            ApplicationUser client12 = new ApplicationUser()
            {
                Id = "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                UserName = "Simona",
                NormalizedUserName = "SIMONA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "simona@abv.bg",
                NormalizedEmail = "SIMONA@ABV.BG",
                PhoneNumber = "+359888333333",
                EmailConfirmed = true,
                FirstName = "Simona",
                LastName = "Georgieva",
                Address = "Izgrev Quarter block 29, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client12.PasswordHash = hasher.HashPassword(client12, "simona123456");
            users.Add(client12);

            ApplicationUser client13 = new ApplicationUser()
            {
                Id = "acb6d047-97c5-4553-82cf-d6042362af1e",
                UserName = "Denislav",
                NormalizedUserName = "DENISLAV",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "denislav@abv.bg",
                NormalizedEmail = "DENISLAV@ABV.BG",
                PhoneNumber = "+359888010101",
                EmailConfirmed = true,
                FirstName = "Denislav",
                LastName = "Georgiev",
                Address = "Mara Gidik street 29, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client13.PasswordHash = hasher.HashPassword(client13, "denislav123456");
            users.Add(client13);

            ApplicationUser client14 = new ApplicationUser()
            {
                Id = "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                UserName = "Daniel",
                NormalizedUserName = "DANIEL",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "daniel@abv.bg",
                NormalizedEmail = "DANIEL@ABV.BG",
                PhoneNumber = "+359899919100",
                EmailConfirmed = true,
                FirstName = "Daniel",
                LastName = "Vladislavov",
                Address = "Mara Gidik street 18, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client14.PasswordHash = hasher.HashPassword(client14, "daniel123456");
            users.Add(client14);

            ApplicationUser client15 = new ApplicationUser()
            {
                Id = "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                UserName = "Daniela",
                NormalizedUserName = "DANIELA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "daniela@abv.bg",
                NormalizedEmail = "DANIELA@ABV.BG",
                PhoneNumber = "+359888030330",
                EmailConfirmed = true,
                FirstName = "Daniela",
                LastName = "Ivanova",
                Address = "Gladstone street block 6, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client15.PasswordHash = hasher.HashPassword(client15, "daniela123456");
            users.Add(client15);

            ApplicationUser client16 = new ApplicationUser()
            {
                Id = "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                UserName = "Stanislav",
                NormalizedUserName = "STANISLAV",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "stanislav@abv.bg",
                NormalizedEmail = "STANISLAV@ABV.BG",
                PhoneNumber = "+359877711771",
                EmailConfirmed = true,
                FirstName = "Stanislav",
                LastName = "Georgiev",
                Address = "Izgrev Quarter block 6, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client16.PasswordHash = hasher.HashPassword(client16, "stanislav123456");
            users.Add(client16);

            ApplicationUser client17 = new ApplicationUser()
            {
                Id = "94280b80-6076-4025-9bf7-ae251fb7bcee",
                UserName = "Stanislava",
                NormalizedUserName = "STANISLAVA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "stanislava@abv.bg",
                NormalizedEmail = "STANISLAVA@ABV.BG",
                PhoneNumber = "+359889126543",
                EmailConfirmed = true,
                FirstName = "Stanislava",
                LastName = "Ivanova",
                Address = "Izgrev Quarter block 22, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client17.PasswordHash = hasher.HashPassword(client17, "stanislava123456");
            users.Add(client17);

            ApplicationUser client18 = new ApplicationUser()
            {
                Id = "109044cd-44fb-470c-b7b9-2724987b08de",
                UserName = "Yovko",
                NormalizedUserName = "YOVKO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "yovko@abv.bg",
                NormalizedEmail = "YOVKO@ABV.BG",
                PhoneNumber = "+359876262626",
                EmailConfirmed = true,
                FirstName = "Yovko",
                LastName = "Ivov",
                Address = "Lazur Quarter block 80, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client18.PasswordHash = hasher.HashPassword(client18, "yovko123456");
            users.Add(client18);

            ApplicationUser client19 = new ApplicationUser()
            {
                Id = "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                UserName = "Yovka",
                NormalizedUserName = "YOVKA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "yovka@abv.bg",
                NormalizedEmail = "YOVKA@ABV.BG",
                PhoneNumber = "+359998919119",
                EmailConfirmed = true,
                FirstName = "Yovka",
                LastName = "Yasenova",
                Address = "Vazrazhdane Quarter block 50, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client19.PasswordHash = hasher.HashPassword(client19, "yovka123456");
            users.Add(client19);

            ApplicationUser client20 = new ApplicationUser()
            {
                Id = "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                UserName = "Boiko",
                NormalizedUserName = "BOIKO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "boiko@abv.bg",
                NormalizedEmail = "BOIKO@ABV.BG",
                PhoneNumber = "+359888147147",
                EmailConfirmed = true,
                FirstName = "Boiko",
                LastName = "Asenov",
                Address = "Vazrazhdane Quarter block 49, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client20.PasswordHash = hasher.HashPassword(client20, "boiko123456");
            users.Add(client20);

            ApplicationUser client21 = new ApplicationUser()
            {
                Id = "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                UserName = "Boyan",
                NormalizedUserName = "BOYAN",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "boyan@abv.bg",
                NormalizedEmail = "BOYAN@ABV.BG",
                PhoneNumber = "+359877742247",
                EmailConfirmed = true,
                FirstName = "Boyan",
                LastName = "Atanasov",
                Address = "Slaveykov Quarter block 20, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client21.PasswordHash = hasher.HashPassword(client21, "boyan123456");
            users.Add(client21);

            ApplicationUser client22 = new ApplicationUser()
            {
                Id = "b87fc486-a805-4fad-89bd-c836281ce8a0",
                UserName = "Boyana",
                NormalizedUserName = "BOYANA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "boyana@abv.bg",
                NormalizedEmail = "BOYANA@ABV.BG",
                PhoneNumber = "+359888159159",
                EmailConfirmed = true,
                FirstName = "Boyana",
                LastName = "Marinova",
                Address = "Slaveykov Quarter block 17, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client22.PasswordHash = hasher.HashPassword(client22, "boyana123456");
            users.Add(client22);

            ApplicationUser client23 = new ApplicationUser()
            {
                Id = "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                UserName = "Genadi",
                NormalizedUserName = "GENADI",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "genadi@abv.bg",
                NormalizedEmail = "GENADI@ABV.BG",
                PhoneNumber = "+359899369369",
                EmailConfirmed = true,
                FirstName = "Genadi",
                LastName = "Atanasov",
                Address = "Hr. Boteb Blvd block 5, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client23.PasswordHash = hasher.HashPassword(client23, "genadi123456");
            users.Add(client23);

            ApplicationUser client24 = new ApplicationUser()
            {
                Id = "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                UserName = "Dragomir",
                NormalizedUserName = "DRAGOMIR",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "dragomir@abv.bg",
                NormalizedEmail = "DRAGOMIR@ABV.BG",
                PhoneNumber = "+359888258258",
                EmailConfirmed = true,
                FirstName = "Dragomir",
                LastName = "Martinov",
                Address = "Hr. Boteb Blvd block 2, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client24.PasswordHash = hasher.HashPassword(client24, "dragomir123456");
            users.Add(client24);

            ApplicationUser client25 = new ApplicationUser()
            {
                Id = "a6dc0238-4999-49e9-93c1-dfd243e36781",
                UserName = "Ilian",
                NormalizedUserName = "ILIAN",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "ilian@abv.bg",
                NormalizedEmail = "ILIAN@ABV.BG",
                PhoneNumber = "+359888654789",
                EmailConfirmed = true,
                FirstName = "Ilian",
                LastName = "Stoyanov",
                Address = "Mara Gidik Street block 8, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client25.PasswordHash = hasher.HashPassword(client25, "ilian123456");
            users.Add(client25);

            ApplicationUser client26 = new ApplicationUser()
            {
                Id = "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                UserName = "Desislav",
                NormalizedUserName = "DESISLAV",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "desislav@abv.bg",
                NormalizedEmail = "DESISLAV@ABV.BG",
                PhoneNumber = "+359899949596",
                EmailConfirmed = true,
                FirstName = "Desislav",
                LastName = "Stoyanov",
                Address = "Mara Gidik Street block 4, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client26.PasswordHash = hasher.HashPassword(client26, "desislav123456");
            users.Add(client26);

            ApplicationUser client27 = new ApplicationUser()
            {
                Id = "22657eba-f41a-4bb3-986e-83ef23fedf15",
                UserName = "Lyuben",
                NormalizedUserName = "LYUBEN",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "lyuben@abv.bg",
                NormalizedEmail = "LYUBEN@ABV.BG",
                PhoneNumber = "+359897357357",
                EmailConfirmed = true,
                FirstName = "Lyuben",
                LastName = "Nikolov",
                Address = "Vl. Varnenchik block 14, Varna 9000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client27.PasswordHash = hasher.HashPassword(client27, "lyuben123456");
            users.Add(client27);

            ApplicationUser client28 = new ApplicationUser()
            {
                Id = "038e5319-0910-4cba-bf80-253a10030324",
                UserName = "Dinko",
                NormalizedUserName = "DINKO",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "dinko@abv.bg",
                NormalizedEmail = "DINKO@ABV.BG",
                PhoneNumber = "+359888124578",
                EmailConfirmed = true,
                FirstName = "Dinko",
                LastName = "Martinov",
                Address = "Lazur Quarter block 13, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client28.PasswordHash = hasher.HashPassword(client28, "dinko123456");
            users.Add(client28);

            ApplicationUser client29 = new ApplicationUser()
            {
                Id = "978959e9-4ec5-49a0-a703-77884cc8d109",
                UserName = "Katerina",
                NormalizedUserName = "KATERINA",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "katerina@abv.bg",
                NormalizedEmail = "KATERINA@ABV.BG",
                PhoneNumber = "+359888951847",
                EmailConfirmed = true,
                FirstName = "Katerina",
                LastName = "Markova",
                Address = "Lazur Quarter block 16, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client29.PasswordHash = hasher.HashPassword(client29, "katerina123456");
            users.Add(client29);

            ApplicationUser client30 = new ApplicationUser()
            {
                Id = "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                UserName = "Dimitar",
                NormalizedUserName = "DIMITAR",
                SecurityStamp = Guid.NewGuid().ToString(),
                Email = "dimitar@abv.bg",
                NormalizedEmail = "DIMITAR@ABV.BG",
                PhoneNumber = "+359888181818",
                EmailConfirmed = true,
                FirstName = "Dimitar",
                LastName = "Dimitrov",
                Address = "Slaveykov Quarter block 68, Bourgas 8000, Bulgaria",
                RegisteredOn = DateTime.Now,
            };

            client30.PasswordHash = hasher.HashPassword(client30, "dimitar123456");
            users.Add(client30);

            return users;
        }
    }
}
