using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValue: "https://www.pngkey.com/png/detail/115-1150152_default-profile-picture-avatar-png-green.png"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ContentFileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContentFileType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programs_Coaches_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersPrograms",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersPrograms", x => new { x.ProgramId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_CustomersPrograms_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPrograms_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42196e3c-e72a-4778-994f-36c85380e060", "ceda0b1d-8123-48f2-abee-44f027f75c11", "Coach", "COACH" },
                    { "9b325984-c63f-4dec-a00b-eeaab3d34035", "6844f1ca-79a9-4580-990d-c3f47f6a88c8", "Customer", "CUSTOMER" },
                    { "b4656095-c561-4bfa-a5ad-08f7678af1bf", "830d72d2-9e67-4620-b5c5-53fd88fa0762", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30b99904-02f5-4465-87a9-f7f12958029a", 0, 33, "3a134f74-550c-4eb1-bc74-bf9377ab14b0", "admin1@mail.com", false, "Petar", "Ivanov", false, null, "ADMIN1@MAIL.COM", "ADMIN1", "AQAAAAEAACcQAAAAEC1FO9/LebKZMGbmyRMNgoFkNhHKpetgYj9MnpumImuHchRA12VE8LvFQvpYaJHZ9g==", "0884810188", false, "fc01c0d1-7dfc-4248-bdfa-8693a081e771", false, "admin1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageURL", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, 25, "ea3750d5-37e4-43a2-9317-463862d6dcaf", "coach1@mail.com", false, "Stanislav", "Chakurov", false, null, "COACH@MAIL.COM", "COACH1", "AQAAAAEAACcQAAAAEHK1fGSJ7aobi6//prgK+y91bMixpz3En45jfFllmMm/vkdJsv/tNMtnIJ7dGRlbiw==", "0123456789", false, "https://media-exp1.licdn.com/dms/image/C4E03AQEZzVQV_QkXxA/profile-displayphoto-shrink_800_800/0/1607428598966?e=2147483647&v=beta&t=0usI7YAARf7h56Xdo_bv6xpYtc9y7pUfD7boyRXD9jk", "28fa6a19-c322-45c8-b728-945a5e34ec62", false, "coach1" },
                    { "e4b69fce-458e-4234-be1d-852bebf15846", 0, 30, "f2055791-faeb-429a-b10b-d8e43a7f6104", "coach2@mail.com", false, "Nikola", "Tomov", false, null, "COACH2@MAIL.COM", "COACH2", "AQAAAAEAACcQAAAAEKM3Ta3e/+B/kIpqLuGbHOg6+1nE0trJHnwnt9NUrzgdrVXq5X0lPWrZPFdFBhfDCQ==", "0222222222", false, "https://media-exp1.licdn.com/dms/image/D4D03AQF2P7FxDvXL_w/profile-displayphoto-shrink_800_800/0/1665589049799?e=2147483647&v=beta&t=UaIubCn4CURIDtu8ZFqW--yzRz0fesLnjAeqUf_iaY0", "09805bd9-ea7c-464b-8ca2-9466bb52a8fc", false, "coach2" },
                    { "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2", 0, 22, "f4713dc8-2333-4160-8b5b-50bbd14275af", "client2@mail.com", false, "Radostin", "Kuzmanov", false, null, "CLIENT2@MAIL.COM", "CLIENT2", "AQAAAAEAACcQAAAAEATi4iKDIIpSB1yVeaCm47EumYOnBoDUU/q6vnY3aGsAHTrGv3JoZz8/OKQAi2M1EQ==", "0256810188", false, "https://yt3.ggpht.com/ytc/AMLnZu9ZGUZqNxqW_GYK3RGSeuYNdDfqO8M6mBgpRmZjDA=s800-c-k-c0x00ffffff-no-rj", "33d462cb-c546-4e29-b7fb-a85bb0c88aab", false, "client2" },
                    { "f17f9cb5-f8ca-4462-85ff-ca3f59136189", 0, 29, "324a0ec2-ec67-4d5e-b1f3-efeee8fcb4c4", "client1@mail.com", false, "Stan", "Subev", false, null, "CLIENT1@MAIL.COM", "CLIENT1", "AQAAAAEAACcQAAAAEIKqdlAFgbfLYbi25648pKOgpzukEGy7pPdoNMZWdOk2/09D4w/RluUijK59/FZ3dQ==", "0885554888", false, "https://i.ytimg.com/vi/VpQCMU3Q0RU/maxresdefault.jpg", "b0b0f8cf-b7c2-48b7-8372-215f92e26ad9", false, "client1" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Powerlifting" },
                    { 2, "Olimpic weightlifting" },
                    { 3, "Streetlifting" },
                    { 4, "Sprint running  brat" },
                    { 5, "Long-distance running" },
                    { 6, "Functional Bodybuilding" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "b4656095-c561-4bfa-a5ad-08f7678af1bf", "30b99904-02f5-4465-87a9-f7f12958029a", "UserRole" },
                    { "42196e3c-e72a-4778-994f-36c85380e060", "dea12856-c198-4129-b3f3-b893d8395082", "UserRole" },
                    { "42196e3c-e72a-4778-994f-36c85380e060", "e4b69fce-458e-4234-be1d-852bebf15846", "UserRole" },
                    { "9b325984-c63f-4dec-a00b-eeaab3d34035", "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2", "UserRole" },
                    { "9b325984-c63f-4dec-a00b-eeaab3d34035", "f17f9cb5-f8ca-4462-85ff-ca3f59136189", "UserRole" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "e4b69fce-458e-4234-be1d-852bebf15846" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "f17f9cb5-f8ca-4462-85ff-ca3f59136189" },
                    { 2, "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "ImageURL", "Title" },
                values: new object[] { 1, 1, 1, "Мускулите, използвани от това упражнение, са главно бицепсите и трицепсите, които повдигат екипировката, четворките, глутеус максимус, мускулите на бедрата и разтегателите на долната част на гърба. Мъртвата тяга също действа на синергичните мускули, особено тези на бедрото и трицепсите на прасеца. За поддържане на баланса, използват се и други мускули, като корема, трапец, делтоиди, раменни шапки и мускули на ръцете. Когато всички тези мускули работят, сами ще се убедите, че мъртвата тяга е пълно упражнение за развитие на цялото тяло. Мъртвата тяга е много полезна за тялото. Повишава издръжливостта на тялото. Също така помага за подобряване на силата на координация и баланс на гърба. Флексии също ще бъде отлично за артикулация.", "https://trenirai.bg/wp-content/uploads/2019/02/deadhlift.jpg", "Ползи от МЪРТВАТА ТЯГА" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_UserId",
                table: "Coaches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPrograms_CustomerId",
                table: "CustomersPrograms",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_AuthorId",
                table: "Programs",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_CategoryId",
                table: "Programs",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomersPrograms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
