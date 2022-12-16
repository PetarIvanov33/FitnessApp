using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class AddProfilePicturesForUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageURL",
                table: "AspNetUsers",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "https://www.pngkey.com/png/detail/115-1150152_default-profile-picture-avatar-png-green.png");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "e8c68c4e-cb00-4859-8a77-d93100af2599");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "2884335a-2333-4839-b7f6-6b217a08080d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "c83540e5-7887-483f-afa6-d98ec168a77c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dec0d12-5d6d-4ad2-a33b-039de3f39406", "AQAAAAEAACcQAAAAENDa50+A8K6pdGAjPIxu9/sNFCs8aAPSCLvQK990EdjSadjCbrygxGf9kZ8N1ypyHg==", "a16654a7-7072-4a7c-af92-7064f605efe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageURL", "SecurityStamp" },
                values: new object[] { "8b212a17-e179-4e5b-92b0-746bc511752a", "AQAAAAEAACcQAAAAEG18xrymFSMn0mxebzAUg1UkzMtKNYa5y3cvufVFXwZ3EEQpD/grB2OoMo2uyc+ELA==", "https://media-exp1.licdn.com/dms/image/C4E03AQEZzVQV_QkXxA/profile-displayphoto-shrink_800_800/0/1607428598966?e=2147483647&v=beta&t=0usI7YAARf7h56Xdo_bv6xpYtc9y7pUfD7boyRXD9jk", "86450658-ee2c-4217-9501-3aab1f3f3274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageURL", "SecurityStamp" },
                values: new object[] { "829bea6f-c7f7-4f5f-b56f-08f2b531bd26", "AQAAAAEAACcQAAAAEK4qZzJ6WtZlWAz7xXOO1PrLWmR0PHEqHn/xAveC1XEG4vaxlWXwRveOaJDgP0Lqeg==", "https://media-exp1.licdn.com/dms/image/D4D03AQF2P7FxDvXL_w/profile-displayphoto-shrink_800_800/0/1665589049799?e=2147483647&v=beta&t=UaIubCn4CURIDtu8ZFqW--yzRz0fesLnjAeqUf_iaY0", "daa8e338-b1cd-4682-8418-44159e1e78de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "ProfileImageURL", "SecurityStamp" },
                values: new object[] { "449b2e51-26bc-4968-9954-c8623140f29d", "Radostin", "Kuzmanov", "AQAAAAEAACcQAAAAELf4ANKuwonRps4namQQKBTEhHKkojTiVIj9rglLLXNz2FCy6+S1NHfZNdM2+dQGBQ==", "https://yt3.ggpht.com/ytc/AMLnZu9ZGUZqNxqW_GYK3RGSeuYNdDfqO8M6mBgpRmZjDA=s800-c-k-c0x00ffffff-no-rj", "21451aff-36af-4ff8-8ff6-e90c9cbe8ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "ProfileImageURL", "SecurityStamp" },
                values: new object[] { "5bf27896-e8ac-4277-b785-11dba64090e7", "Stan", "Subev", "AQAAAAEAACcQAAAAEOWgVaR9lzmm6qdkReoBs7vvr5LF+tYm8NxcUG+8WxvGHPWB37xddoFW9SJoCSVLyw==", "https://i.ytimg.com/vi/VpQCMU3Q0RU/maxresdefault.jpg", "a34a41af-dc1d-49b8-9138-38982f7036e7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageURL",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "25131868-1ac8-4825-a46f-c876601d6c2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "4132b12d-9a43-4980-85eb-95dd594480d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "2aa65b44-8acd-43e2-9083-3f306e4c7753");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ca3693-54ef-4ae1-a309-4755d4fb036d", "AQAAAAEAACcQAAAAEBP6ydd+Og58Cw8LzF81cjb8LS/r1HjATsgSdTpVgPL45chhftQI6Spb4+AARw9dfA==", "46ef934f-5ef3-4b6a-90a7-2616f2b7c190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4c17445-00be-48d5-9727-8c7f9fcd0de3", "AQAAAAEAACcQAAAAEPV51znMl4AS6FNBc0cNWwULYjc+csoE6K2MW2ugXgKHELe8iaMDOtCVuwaNC6GJ6A==", "3b5ba587-d382-4fdb-a780-c51f1f411dce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b7c3bb7-c725-4b4c-ad3c-b6079f4cce89", "AQAAAAEAACcQAAAAEEFC0fqMmdK05LfFgUTWuToEDyKaytzSrUVLdRuAui3kpj4d0R/ruxJadSBG4pV90w==", "6aad8c08-b9cc-46a4-b3fd-68821bfaf6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73427a2c-76df-49ec-afaf-b2e4a4c7cca9", "Georgi", "Shishkov", "AQAAAAEAACcQAAAAEM+27nGlaIgWBmwWLIBtQ7h9p0SvE4KS8qs2Zm7bK2ezu38GhfpJFMFCpk8wBvvcWw==", "210a316e-f26b-405e-8def-89923361de02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c60ad92-ac6e-4f5e-9a09-2ccb3310e778", "Kaloqn", "Cholakov", "AQAAAAEAACcQAAAAECBzCPLuK50GR+K2DJHOzOj1Oo75F2fjKs0UufBdQn2QgJdWao5Bpv8RR31zYLC7+g==", "e8f49b11-b886-43e2-a756-cc0600905e76" });
        }
    }
}
