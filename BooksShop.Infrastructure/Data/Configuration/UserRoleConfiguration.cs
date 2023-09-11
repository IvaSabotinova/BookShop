namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(this.CreateUserRoles());
        }

        private List<IdentityUserRole<string>> CreateUserRoles()
        {
           List<IdentityUserRole<string>> list = new List<IdentityUserRole<string>>()
           {
             new IdentityUserRole<string>
             {
                 UserId = "283073f1-cc28-485a-ab58-44f4ed128264",
                 RoleId = "ec3a92cc-8b64-4b83-bc6a-c20031faa327",
             }, // clients
             new IdentityUserRole<string>
             {
                 UserId = "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "45538c3e-df96-4b79-86dc-e190def35cf4",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "7a09fc16-8d35-48e4-bf98-532a876423f2",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "0908214c-eac6-4029-b303-8d987037c4ad",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "f18ff312-2889-46df-a392-264b865a2c72",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "2c2467dc-c396-46ce-af79-da3e48398f4a",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "2708e501-67b2-4c5b-aacd-9a044df9de21",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "acb6d047-97c5-4553-82cf-d6042362af1e",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "94280b80-6076-4025-9bf7-ae251fb7bcee",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "109044cd-44fb-470c-b7b9-2724987b08de",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "b87fc486-a805-4fad-89bd-c836281ce8a0",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "a6dc0238-4999-49e9-93c1-dfd243e36781",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "22657eba-f41a-4bb3-986e-83ef23fedf15",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "038e5319-0910-4cba-bf80-253a10030324",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "978959e9-4ec5-49a0-a703-77884cc8d109",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
             new IdentityUserRole<string>
             {
                 UserId = "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                 RoleId = "b1353077-7dcd-4f94-820b-f8af8feb9690",
             },
           };

           return list;
        }
    }
}
