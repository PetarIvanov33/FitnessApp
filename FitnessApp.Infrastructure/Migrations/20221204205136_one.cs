using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Ползи от МЪРТВАТА ТЯГА");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42196e3c-e72a-4778-994f-36c85380e060",
                column: "ConcurrencyStamp",
                value: "19002885-431b-4dcc-b2df-87536006217e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b325984-c63f-4dec-a00b-eeaab3d34035",
                column: "ConcurrencyStamp",
                value: "91ef9024-f1ec-4f61-8e3b-41dd99312268");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                column: "ConcurrencyStamp",
                value: "30fd4f06-d2c0-4653-bd26-fd33ccac2685");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bbeb3a2-9cce-48e8-b701-cf6dd80063f9", "AQAAAAEAACcQAAAAEBjA6nXKEEHyhrOo93Jznc2vhyUzGj4qlBNsKqNvtunNIl483QQ4k7kM22jVyrz1XA==", "e7cfd39d-70c1-4e0c-b0d9-beadd96597cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d89b466d-87a6-4e6f-9c5f-2818d01cb0d4", "AQAAAAEAACcQAAAAEHhqPY9+aigbu0hCs7/BL7CFaTtjGWO0GrSMZXKiJnsXkOgcK/gY1+LhnCURnwX/Yg==", "9ea56646-c31b-42af-a10d-45fb274f7f1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf25963-6d7b-45b2-98a9-916551153c58", "AQAAAAEAACcQAAAAEDnZVrgTi9Jnf2E5ATym2GNiGLmImHZGug3aXTqEBHDeagF1fRUkOs34nn0NoPgY7Q==", "2206d9b1-ba0c-4daa-b9e9-3012f82e2b13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9dc2280-97bb-4704-83ba-04259e0c8063", "AQAAAAEAACcQAAAAEKQhnniFEoEI/4Yb8P3P7YQGuWksTvSzUwPXRmrzx7qmhGR27Co9iI34iEtexOU2KQ==", "d883ea2c-f160-4724-aa5d-8dab3c24df9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2fce8b8-e2f8-45bd-8a2b-1448a3521c7d", "AQAAAAEAACcQAAAAEHhekoRPdmhdLx1Wgit2s6yItBJjrDvYDkOcoqkxX2b6ndct2NjUckHRoXL2c/qv6g==", "5c6137a7-c6df-40e1-96c4-50f5e75edba4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Поузи от МЪРТВАТА ТЯГА");

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
        }
    }
}
