using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30b99904-02f5-4465-87a9-f7f12958029a", 0, "299179bf-2f1c-4a07-a73c-b0c914f91204", "coach3@mail.com", false, false, null, "coach3@mail.com", "coach3", "AQAAAAEAACcQAAAAEOOKxYceHQ6IeZSa/IIh+oBpKrNOnMgEUWpSUz5qWcU9tQffml6y99BBm4ASj9u5zA==", null, false, "7f0f2da9-f00b-4c44-b9c3-36f50298a09a", false, "coach3" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "ae53f39e-7b5c-49eb-8ebc-841b26b45a99", "coach1@mail.com", false, false, null, "coach1@mail.com", "coach1", "AQAAAAEAACcQAAAAEGYzmE8Wdv5JgQffUpr5UY92IOZz0IKtgY7FssGw9lGCpJOidi3L/+DBERlE9wvfqA==", null, false, "0e7f1a9e-c503-4bca-b0bf-8408cbe5a5cb", false, "coach1" },
                    { "e4b69fce-458e-4234-be1d-852bebf15846", 0, "d2783dba-a520-41ea-ab58-ebc7043e0908", "coach2@mail.com", false, false, null, "coach2@mail.com", "coach2", "AQAAAAEAACcQAAAAECv+hFNyZDZf0ZXeuFiiKToXJv533pJs/DLg4yqTLwkKXq8tT3boTfnqiAbri91UgQ==", null, false, "1b3b136f-44bf-43f8-8e81-02acf9a79ea2", false, "coach2" },
                    { "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2", 0, "a3c05624-5f78-44a9-8ef9-a5f7e37a5dc5", "client2@mail.com", false, false, null, "client2@mail.com", "client2", "AQAAAAEAACcQAAAAEJNmrtW9bFWMSFc7Bxtbzlkoczf0iGOWA4s+NxNBGHKVsMVNIhOcdIfdCoAPUW81MQ==", null, false, "4cbf2313-2703-4222-b302-3b96cdf4f1ab", false, "client2" },
                    { "f17f9cb5-f8ca-4462-85ff-ca3f59136189", 0, "d17f1277-52d0-4173-a9b1-b009c3203c64", "client1@mail.com", false, false, null, "client1@mail.com", "client1", "AQAAAAEAACcQAAAAENU9dbz74SOYCgb+Zb5hivy/iofk+3Hevyrm5TD6i56pwhvxNOMFp/HOTCdYsc7XBg==", null, false, "bd20aa96-bff1-45d3-a8fd-d633f22c6777", false, "client1" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, 25, "Dimitar", "Petrov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, 33, "Dimitar", "Ivanov", "e4b69fce-458e-4234-be1d-852bebf15846" },
                    { 3, 40, "Ivan", "Petrov", "30b99904-02f5-4465-87a9-f7f12958029a" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, 18, "Dimitar", "Marinov", "f17f9cb5-f8ca-4462-85ff-ca3f59136189" },
                    { 2, 22, "Emil", "Krustev", "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30b99904-02f5-4465-87a9-f7f12958029a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4b69fce-458e-4234-be1d-852bebf15846");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f17f9cb5-f8ca-4462-85ff-ca3f59136189");
        }
    }
}
