using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class AddProgramContentFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentFileName",
                table: "Programs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentFileName",
                table: "Programs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "1247623c-c121-482f-b136-d761eece78d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "88831564-f707-40fe-8e3c-d69cb8c8a5e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "1de9adf7-5e53-49de-b1fc-bf240bdffd7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27f877d7-8b44-401c-a0ad-1eac92043112", "AQAAAAEAACcQAAAAEGbZoAxgq8DVWyOglwhrx+qHTvqdOxXbshwewLmKHHs7/WJZs5dPrhz3d1DpFSnM+g==", "c630ded0-eebf-4843-981e-6933c8acb96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c159c2e-b7b7-4958-a2d4-cda83dc111db", "AQAAAAEAACcQAAAAEC6nuK0QTZl8dK82+GwTq8HYiuo4vlcKUElwQsd2miu0Bc+wEQr5NlQbZH838Zj5fg==", "4175de98-2299-4749-a1f6-43269d20a27d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a352e7a1-f15d-4932-af11-ce16ae8f454d", "AQAAAAEAACcQAAAAEGun3ZtDTZpZm777tSCTSmRCgoTzcLUzPm1VuSNaordnmklVoMYStV11m1sOuYyLxQ==", "5d723c71-5e79-4695-a24c-0b93fc3c6edd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0e2aef-1355-4015-8e8a-c8d065d2a7b3", "AQAAAAEAACcQAAAAEIcTKY9oseIbDfm37yd8ymAOaOTClZdP3pxlTgfDCVdfct5Cw6eUT5EKrdNTgeA8/Q==", "794be09f-7a47-424c-b8ac-2f7744eb4655" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df0cfd30-cb05-4a45-a48b-3fc2fc8b1841", "AQAAAAEAACcQAAAAEDECCnt8fRn7yoLgq7jRChaENMNX73Glc++31SSDS1wRFm8LqdGzwrss0RlDVq+xcw==", "accd0269-af6e-4468-947d-352211d159a4" });
        }
    }
}
