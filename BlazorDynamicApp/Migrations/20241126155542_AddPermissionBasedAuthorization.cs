using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorDynamicApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPermissionBasedAuthorization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resource = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermissions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11c174c2-94cc-4615-8d46-4655dee45ea7",
                column: "ConcurrencyStamp",
                value: "6921c27f-9436-439b-91db-7707abbac2da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "e2453448-e9d3-4fbb-9600-447cc0235815");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "c7400c07-ea78-458b-8efd-80e209675626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de820986-a707-4cc5-8306-776812617837",
                column: "ConcurrencyStamp",
                value: "2e2fffd1-bdae-4ca9-9d01-25a33a0dcbd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba8a713-cddc-4730-aed8-5a8ce8b53688", "AQAAAAIAAYagAAAAEMNN08BYKebhmmna9LWz3tsHgl09qdV9BxHDXotARko+PvbcYjYWIfk2bKf4jdGKHw==", "e3e6571e-e871-4c5f-8fe1-3f5b616ecdb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d12eaebd-babd-46da-8eed-e19e89958bfb", "AQAAAAIAAYagAAAAEHHC5XPMKjScE3e/FBYh9HeJZnq4FeFiySL728R+Cx9+JllYq4vKScXraFiMzx8SPw==", "1aca4e1e-b4f4-4fb2-8ca5-d0aa10e5a71e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6573a843-0de1-4f3c-aec2-59d778e42cff", "AQAAAAIAAYagAAAAEEFWsIhFRBFxF0aHONeUUzYvH0+7Z5e/kHoF6tSWSQEKKa4Y21WrhaMAKt9X3T7ftg==", "5e832a77-9ba3-4176-9ad4-9690df0194ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57fa6998-a1db-4e41-a0ad-75f7cad2d9a3", "AQAAAAIAAYagAAAAEOGDRzY0qcxpkvM43W3RaQK1Hf4Rf3tjl8zfuIi4cxEpdf6/Z2OelS+d6xZvu0jwNA==", "b2c2b7cc-c84b-43f4-ab66-7082f32d75bc" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name", "Resource" },
                values: new object[,]
                {
                    { 1, "Create", 1 },
                    { 2, "Edit", 1 },
                    { 3, "Delete", 1 },
                    { 4, "View", 1 },
                    { 5, "Create", 0 },
                    { 6, "Edit", 0 },
                    { 7, "Delete", 0 },
                    { 8, "View", 0 },
                    { 9, "Create", 2 },
                    { 10, "Edit", 2 },
                    { 11, "Delete", 2 },
                    { 12, "View", 2 },
                    { 13, "ViewRolePermissions", 2 },
                    { 14, "AddPermissionToRole", 2 },
                    { 15, "RemovePermissionFromRole", 2 },
                    { 16, "Create", 3 },
                    { 17, "Edit", 3 },
                    { 18, "Delete", 3 },
                    { 19, "View", 3 },
                    { 20, "ViewUserPermissions", 3 },
                    { 21, "AddPermissionToUser", 3 },
                    { 22, "RemovePermissionFromUser", 3 },
                    { 23, "ViewUserRoles", 4 },
                    { 24, "AddRoleToUser", 4 },
                    { 25, "RemoveRoleFromUser", 4 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, "de820986-a707-4cc5-8306-776812617837" },
                    { 2, 2, "de820986-a707-4cc5-8306-776812617837" },
                    { 3, 3, "de820986-a707-4cc5-8306-776812617837" },
                    { 4, 4, "de820986-a707-4cc5-8306-776812617837" },
                    { 5, 5, "de820986-a707-4cc5-8306-776812617837" },
                    { 6, 6, "de820986-a707-4cc5-8306-776812617837" },
                    { 7, 7, "de820986-a707-4cc5-8306-776812617837" },
                    { 8, 8, "de820986-a707-4cc5-8306-776812617837" },
                    { 9, 9, "de820986-a707-4cc5-8306-776812617837" },
                    { 10, 10, "de820986-a707-4cc5-8306-776812617837" },
                    { 11, 11, "de820986-a707-4cc5-8306-776812617837" },
                    { 12, 12, "de820986-a707-4cc5-8306-776812617837" },
                    { 13, 13, "de820986-a707-4cc5-8306-776812617837" },
                    { 14, 14, "de820986-a707-4cc5-8306-776812617837" },
                    { 15, 15, "de820986-a707-4cc5-8306-776812617837" },
                    { 16, 16, "de820986-a707-4cc5-8306-776812617837" },
                    { 17, 17, "de820986-a707-4cc5-8306-776812617837" },
                    { 18, 18, "de820986-a707-4cc5-8306-776812617837" },
                    { 19, 19, "de820986-a707-4cc5-8306-776812617837" },
                    { 20, 20, "de820986-a707-4cc5-8306-776812617837" },
                    { 21, 21, "de820986-a707-4cc5-8306-776812617837" },
                    { 22, 22, "de820986-a707-4cc5-8306-776812617837" },
                    { 23, 23, "de820986-a707-4cc5-8306-776812617837" },
                    { 24, 24, "de820986-a707-4cc5-8306-776812617837" },
                    { 25, 25, "de820986-a707-4cc5-8306-776812617837" },
                    { 26, 1, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 27, 2, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 28, 3, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 29, 4, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 30, 5, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 31, 6, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 32, 7, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 33, 8, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 34, 9, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 35, 10, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 36, 11, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 37, 12, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 38, 13, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 39, 16, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 40, 17, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 41, 18, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 42, 19, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 43, 20, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 44, 23, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 45, 24, "8815f0d6-db8e-4606-8acb-12844e7b796b" },
                    { 46, 1, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 47, 2, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 48, 3, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 49, 4, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 50, 5, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 51, 6, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 52, 7, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 53, 8, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 54, 12, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 55, 19, "11c174c2-94cc-4615-8d46-4655dee45ea7" },
                    { 56, 4, "d140eb54-ed6e-4ff2-9199-71fcbe722ef7" },
                    { 57, 8, "d140eb54-ed6e-4ff2-9199-71fcbe722ef7" }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "PermissionId", "UserId" },
                values: new object[] { 1, 23, "d7ebd93d-0642-4ab9-8da3-4b6b2046e540" });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_PermissionId",
                table: "UserPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_UserId",
                table: "UserPermissions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11c174c2-94cc-4615-8d46-4655dee45ea7",
                column: "ConcurrencyStamp",
                value: "a1f0e591-dd95-4aa4-a48d-8b7d83c97c9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "58e76bc7-5f25-4140-9883-bc1b5de5c0e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "e9543a42-af9a-4b47-815e-69576f8d90d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de820986-a707-4cc5-8306-776812617837",
                column: "ConcurrencyStamp",
                value: "68cfd492-e5d9-4942-be8d-d83cf2f133cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa34fbc-6ab0-4873-a760-56c5933de26b", "AQAAAAIAAYagAAAAEGmD+z3l3Xfr5zGZaFSgIPqPsdb6N2LGCFBtSSaNgSUxI1WGr3/k7tyqZc1E5eFtbw==", "c6bb6bac-da86-499f-9bbe-75e332656068" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f107de0e-221e-40b0-948b-0ffb92e20d11", "AQAAAAIAAYagAAAAECEiwJElxp/2/v4NaB01elcrmAlmEe5rnCb718kkeIHbpHQTENb9NsCENIGAHP03SQ==", "2b1043c8-7e3a-4461-807e-a984137ee8b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe44a99b-438e-4a2e-aa52-f11521d8efdc", "AQAAAAIAAYagAAAAEDvZJXwsPvyUpd/Yx+zXT4ArCpuP4frNfxmhSKLW5lTo5R+4gYYU1CVdflqu9u/32Q==", "ad1b5b03-cfc8-44cc-ab68-275a21d98375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "befb8a30-868f-4e53-b5c3-0c05761d2b18", "AQAAAAIAAYagAAAAECJYAlY1AzdP+zP2yXNTKcmJBBk4oHoa7nU5U8Qkgb8Ts/KZXG+Nd8jY3er/wlPuRA==", "c5438082-1104-45f7-8342-703ca1f5c2f6" });
        }
    }
}
