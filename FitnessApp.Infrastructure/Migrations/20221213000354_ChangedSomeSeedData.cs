using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class ChangedSomeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "6718f9e1-4fd6-439f-8410-6fa439f79f51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "cb0aa75f-df1c-46c9-bd0a-04c2ea6fabb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "3f5b1d6d-ae61-4aad-a1d2-cb0f9add6678");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3075d356-6d40-4eda-b96f-696d6553291f", "AQAAAAEAACcQAAAAEI8C2l8b7pY2eS+goA6uz1VstxFzGYoE17Fw5osIPUCsQRaamu6asjyJoMPUvnTmNw==", "2d8d1b20-71f4-43e3-a6d5-835ade9c40b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61ff2a36-34df-45e5-8306-dbeb439cd05a", "AQAAAAEAACcQAAAAEDYaqK1FyATgh0dhF3kcMvMvbwc1gy4Drf2cB0I79syRenA5RDdXAqJ6PttQ7II8/g==", "2a39a329-f3fd-4754-b119-8f6f057888fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc971468-5330-43fd-9281-7bbf4b3e9e4e", "AQAAAAEAACcQAAAAELqIfXD/zrAKlT/bRwLGuRnmwTqT4K3vLh4wkQwpk0SXipW30oFqfSwaXsl19tC1EQ==", "664b4635-c596-4a5d-8b1e-420233284f7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b8d6354-56ac-4669-88fe-175175f7a0ec", "AQAAAAEAACcQAAAAEIp1Qgp5kU/migNoSFSuD+KYXEk7A0d7lsRRuW9PeWMKSIOxBXVRhvli/mmPR1ZVGQ==", "2faaf579-b7b7-46d9-86ff-c35c7a2f2e6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40ee7bb1-7ee5-476d-86c5-65200cfcfaec", "AQAAAAEAACcQAAAAEO8VqXEpgbY9jBY3jwrLwZTzdeNyB+JHM6F2KowauF40Ss3+3tRhmJZqv+mqDUMJFA==", "f11d529d-a23d-4fd3-96a1-0cd37a079717" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Functional Bodybuilding" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "69e6cfc5-e49d-4033-9d31-b915bbfd4cd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "653c88e9-2ab4-4f6a-9619-e503b74f766f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "3db3e1f6-a1bb-4cc6-a446-145619546944");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96eaa386-06cb-4f82-8cac-109a4b8ebd30", "AQAAAAEAACcQAAAAEFmLX0SCmv0Og/YH3K4WBE4ogZcnSAe9nBvM4WYsK+l+2+LgfF6XuoeVUNaRVViwjA==", "0c2a66c2-066b-4661-9734-524e10256f5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f8e0eb-6592-4c95-ada0-150dda290863", "AQAAAAEAACcQAAAAEMa2ufiTsiLI6GhSniSqTtNm5SXKUrTfjsDuP+ru6wFPcFhkbR23Qjrp5Jqvuw3gmg==", "ccada258-9706-45e8-969f-837d8ba88385" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4796fcb-93af-46a7-8128-acf32190999b", "AQAAAAEAACcQAAAAEG2rzY8uF9xSNhKJAOevdCixY3fHmikd/mYclD4r2vNNkMoLzXLbD3xua7QkPDIrfg==", "18f5857e-c454-42b6-bd2b-5188a5451867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c3e6724-133d-4e1f-bc05-f9738ce2ea5d", "AQAAAAEAACcQAAAAEPDqvohNd+B+voOwJGx1N+64uGUIhAE+4HdffWNdUDe1hTrfO4fkfjZz2EC50fbQfQ==", "09b677be-7c53-49d6-94a7-461e18ff2441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4903bbb3-e069-4471-be4a-9727674c4b03", "AQAAAAEAACcQAAAAEFN0V/poA4LSxv3RBFh2iSzESKa0vpaGMgal4BIww5G0Mra6UP+LuF0Cus5NOOBN3w==", "4c9733e9-cfeb-4cfc-93eb-a872ec3bc1ea" });
        }
    }
}
