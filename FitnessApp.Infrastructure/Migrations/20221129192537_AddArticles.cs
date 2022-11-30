using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class AddArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Coaches_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 1, 1, 1, "Мускулите, използвани от това упражнение, са главно бицепсите и трицепсите, които повдигат екипировката, четворките, глутеус максимус, мускулите на бедрата и разтегателите на долната част на гърба. Мъртвата тяга също действа на синергичните мускули, особено тези на бедрото и трицепсите на прасеца. За поддържане на баланса, използват се и други мускули, като корема, трапец, делтоиди, раменни шапки и мускули на ръцете. Когато всички тези мускули работят, сами ще се убедите, че мъртвата тяга е пълно упражнение за развитие на цялото тяло. Мъртвата тяга е много полезна за тялото. Повишава издръжливостта на тялото. Също така помага за подобряване на силата на координация и баланс на гърба. Флексии също ще бъде отлично за артикулация.", "https://trenirai.bg/wp-content/uploads/2019/02/deadhlift.jpg", "Поузи от МЪРТВАТА ТЯГА" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "77e1d4be-1010-4e75-b5cb-3ec1fd1fce31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "8ff0be63-f394-40ba-9643-bd1dd86ee380");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "07a9e7ed-ee0f-46fa-b831-f3106482ec9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbea6942-7925-4b63-8a92-18fb20b959ae", "AQAAAAEAACcQAAAAEIyayEfTSGxCosUW4Am1fFx8GMIphq64WPWjoFasHiv63YoTO1A6eW17x4f+eMF2DA==", "6fee6584-072c-4d07-9c06-44650a15c307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dcf2c4f-b587-47e2-8830-2c57f23de54f", "AQAAAAEAACcQAAAAECP/wo4Xb6UXRE8hkph6ZX1H766NCW0y2nFTOXqqkJUFQq30Rjk2VIIzD2epakjhBw==", "d6833584-f282-4bac-b52e-69e4c7187959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f37f521-e6bc-443d-877c-35ab2b6fedd9", "AQAAAAEAACcQAAAAEHAEqRnnMcS15VDoOsUWyJTB3HMMbMOfWdNplofvd5POAPilk3BvwGT0siDCRAJ9Mg==", "1fe8b14e-aa29-4689-82cb-acfbea13429f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4488e3b-4530-4fb2-8197-3005cd5058f4", "AQAAAAEAACcQAAAAEK4hjSHRwUAH226Um9sr8Ysvu+foaK5mlzFdyQcCE9os3WOn40tDMPeWHlpRH4JJbw==", "d66f295e-dfb5-4348-86e9-7063c728e020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "628b901a-a0b3-4442-9bce-770ef680bb0d", "AQAAAAEAACcQAAAAELrheIQBOYEbSfv24z7CxkNihU3tMHFYycRjPGCCo8xqnBsu78MgnIBy4Pbcdqn19w==", "d47be825-ef1a-45f3-a77a-2086671dbe20" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "c9885a3f-327b-4f4f-a9db-5e81e9fc3e83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "8f9453f6-272a-4543-aa83-5b07d0a3183e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "a4df4dca-e4f9-4988-b4d0-7f0671f02087");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc3917c-396b-4bea-a1a2-83458fff9bfc", "AQAAAAEAACcQAAAAEJxQSgcmDjI7IFVG+my9YhwDvh/3MwNnmAzHRT1gYVt3Pk9niGLEcqm+0XLBCLgjqw==", "e941f161-d3a1-4180-a3c3-11b3dd1e9156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ba3cc4b-3aea-444f-bb39-2093ef8d3d91", "AQAAAAEAACcQAAAAEPcij06ACPEdX1DUGFH82Q9ILCbFpKuWS9qI8xdogIKlME9xQSPOacZxByII0TEWSQ==", "3007b231-7b93-49ae-9c3d-dd144be7112c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aa59338-de18-4b55-a553-26953f8b7af1", "AQAAAAEAACcQAAAAEOGeRH1XQhD8WVrtdygO8HxKAHn7GBbx8FFiqqwLnVqVqhDgDQ6F9BPuL+TCXe67EQ==", "82bb6c56-5b89-4580-9a28-46efcf345557" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47145e0e-53ea-42f6-8286-82b694472676", "AQAAAAEAACcQAAAAELEVT069MF9PbQ9GrvmhLyq2Xa2jKPtD5YTiPpblMhGbgjNC+qgHINDrRG0sHlNBUg==", "1bf0f111-769a-48bd-9c75-eb5519454dc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4503b717-0bd7-4640-8acf-93d8ba4293c0", "AQAAAAEAACcQAAAAENCZKZyfJb7VKULJV2EHm9rIQgeQfPlWHOulEbiW+RtxZ/HfsRlRmynK7QqJzPlp3A==", "22059e5a-4687-446c-ba34-e4add1ef9333" });
        }
    }
}
