using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorDynamicApp.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
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
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11c174c2-94cc-4615-8d46-4655dee45ea7", "9e58110b-d30c-4000-8a32-627b34669390", "Manager", "MANAGER" },
                    { "8815f0d6-db8e-4606-8acb-12844e7b796b", "d103e61f-4438-41ef-bc95-9bdb8c344cc4", "Admin", "ADMIN" },
                    { "d140eb54-ed6e-4ff2-9199-71fcbe722ef7", "4f28d5f1-8ecd-4993-b87d-d78745c3a982", "Member", "MEMBER" },
                    { "de820986-a707-4cc5-8306-776812617837", "f987a102-6617-4a41-942b-dd9e258f6c16", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "256ac0cc-c4b0-458d-957d-24cbfd49225b", 0, "d8c92822-49de-421e-ba52-4ba5c849564b", "pirmatovalisher000@gmail.com", true, false, null, "PIRMATOVALISHER000@GMAIL.COM", "PIRMATOVALISHER000@GMAIL.COM", "AQAAAAIAAYagAAAAEG7IXrzp305EfQ5vEBnuyZnNwVLlwDnvo0idTXy5HA5F5OzsED3ve7QpndZ0JzgMsw==", null, false, "b1cfbfd2-952d-4ec9-b675-ae1e64031fd1", false, "pirmatovalisher000@gmail.com" },
                    { "2ade9cc9-9152-4209-ae22-f2e9e57b09a7", 0, "631ed5f6-bbd2-4fbf-a5e1-80c6fcb1bd09", "pirmatovalisher@gmail.com", true, false, null, "PIRMATOVALISHER@GMAIL.COM", "PIRMATOVALISHER@GMAIL.COM", "AQAAAAIAAYagAAAAEGSkRRiqTNM8biSQQiQk0PNMKGN+4TTraNbmFL/8nJxP8E3nXkSe44GzJkktozXbSA==", null, false, "abfacf88-faec-44d4-accc-c0a4a38ea02f", false, "pirmatovalisher@gmail.com" },
                    { "bb49ce85-c5c9-41d9-9665-321d430b7e2e", 0, "e53bc9fd-dad4-43cc-95fc-7aaba0db71df", "pirmatovalisher2000@gmail.com", true, false, null, "PIRMATOVALISHER2000@GMAIL.COM", "PIRMATOVALISHER2000@GMAIL.COM", "AQAAAAIAAYagAAAAEJgIgueFytBstbyUKjMLmAWBiyKUBOxN4xILnOk/giL/B04p7rrDHHm0H+QG3rP7fA==", null, false, "7aecce23-896a-4cba-8fec-18933cba9cc5", false, "pirmatovalisher2000@gmail.com" },
                    { "d7ebd93d-0642-4ab9-8da3-4b6b2046e540", 0, "88ef5b2c-1b9d-4070-97c7-1fd7dca0d75d", "pirmatovalisher0000@gmail.com", true, false, null, "PIRMATOVALISHER0000@GMAIL.COM", "PIRMATOVALISHER0000@GMAIL.COM", "AQAAAAIAAYagAAAAEGnOkIyCqyUnGs14mersDVJfdvE5Ja5kUh3smc62qy3tSWUbofqZFLsKqQ2gigOUNA==", null, false, "845287f3-02d3-49ce-b28b-6a79dd2b84af", false, "pirmatovalisher0000@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "11c174c2-94cc-4615-8d46-4655dee45ea7", "256ac0cc-c4b0-458d-957d-24cbfd49225b", "ApplicationUserRole" },
                    { "8815f0d6-db8e-4606-8acb-12844e7b796b", "256ac0cc-c4b0-458d-957d-24cbfd49225b", "ApplicationUserRole" },
                    { "d140eb54-ed6e-4ff2-9199-71fcbe722ef7", "256ac0cc-c4b0-458d-957d-24cbfd49225b", "ApplicationUserRole" },
                    { "de820986-a707-4cc5-8306-776812617837", "256ac0cc-c4b0-458d-957d-24cbfd49225b", "ApplicationUserRole" },
                    { "d140eb54-ed6e-4ff2-9199-71fcbe722ef7", "2ade9cc9-9152-4209-ae22-f2e9e57b09a7", "ApplicationUserRole" },
                    { "11c174c2-94cc-4615-8d46-4655dee45ea7", "bb49ce85-c5c9-41d9-9665-321d430b7e2e", "ApplicationUserRole" },
                    { "8815f0d6-db8e-4606-8acb-12844e7b796b", "bb49ce85-c5c9-41d9-9665-321d430b7e2e", "ApplicationUserRole" },
                    { "d140eb54-ed6e-4ff2-9199-71fcbe722ef7", "bb49ce85-c5c9-41d9-9665-321d430b7e2e", "ApplicationUserRole" },
                    { "11c174c2-94cc-4615-8d46-4655dee45ea7", "d7ebd93d-0642-4ab9-8da3-4b6b2046e540", "ApplicationUserRole" },
                    { "d140eb54-ed6e-4ff2-9199-71fcbe722ef7", "d7ebd93d-0642-4ab9-8da3-4b6b2046e540", "ApplicationUserRole" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
