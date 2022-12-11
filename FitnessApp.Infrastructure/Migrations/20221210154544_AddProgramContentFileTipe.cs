using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class AddProgramContentFileTipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentFileType",
                table: "Programs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentFileType",
                table: "Programs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "28fa98bc-b8b3-45c8-b603-f1b3448388af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "3c138496-fc85-4a3c-ae5f-7a024d44b29d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "3b6d3831-b269-49c8-8274-779dfb7616dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11f21b22-ddf9-47ec-a21f-7c9830497114", "AQAAAAEAACcQAAAAEFT6wwXCmv2Wf6MaGTFy2R40T+Bp1pOsjVp9ovhwCPTXzfj/eFesE75dJI/SDbnZfw==", "8120338b-8cf9-448f-966a-b643fb67efcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf62d210-bb14-491f-afc7-58b251984fcb", "AQAAAAEAACcQAAAAEBYMYJe/mSqiPyhENc0L14ckDMkplUgTosSG3LSi/tGV9IvoyLqaYL+XRB8XzYElzA==", "6fc6485a-d458-4d09-bb8a-f58834e29ba0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e175e642-90bf-4e49-892c-1552859a0b5c", "AQAAAAEAACcQAAAAEOjSQyPVuB0FZyDa78I+UIv1xNI22qZ/+L1ZztY8WYFHVG07OpKPZIWMYvvwz6hKIQ==", "f1c4047f-b5e7-4279-a29f-1fe21ab0a3f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98eb43e3-cf57-4dba-9ddd-25ba63077011", "AQAAAAEAACcQAAAAEA/caQpjAB31lsr5Mhw7qMhEwgD04tmEGE4JlByaSPxIKJqt7iZg22uGnyi5Nxmv2Q==", "ea0aca7e-03c6-4e99-b96d-7e8d99d3ecd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a4d5233-9f22-4566-a966-e93f446abf96", "AQAAAAEAACcQAAAAEFxl/M17xejO+xar8j7cWdZXCKZRF8MRe6SQqTsygpSkoj8xCqh3Mg3+zCZBcY3IuQ==", "f2657fa8-afde-4f24-ba73-b9809b338349" });
        }
    }
}
