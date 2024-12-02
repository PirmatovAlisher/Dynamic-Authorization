using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorDynamicApp.Migrations
{
    /// <inheritdoc />
    public partial class AddResources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DateOfBirth", "Department", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 31, new DateTime(1994, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "DMA", "Arjun", "+998943619925" },
                    { 2, 42, new DateTime(1983, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Welding FD", "Satya", "+998943568941" },
                    { 3, 46, new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCS", "Prashant", "+998939784578" },
                    { 4, 56, new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCS", "Test4", "+998939784578" },
                    { 5, 22, new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCS", "Test5", "+998939784578" },
                    { 6, 26, new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCS", "Test6", "+998939784578" },
                    { 7, 31, new DateTime(1979, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCS", "Test7", "+998939784578" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Sweet one", "Pumpkin", 9990 },
                    { 2, "Juicy tomato", "Tomato", 5990 },
                    { 3, "Zero sugar", "Coca-Cola", 12990 },
                    { 4, "From Vietnam", "Orange", 7190 },
                    { 5, "Small one", "Cucumber", 3990 },
                    { 6, "Green one", "Pear", 5990 },
                    { 7, "Double peach", "Peach", 7790 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11c174c2-94cc-4615-8d46-4655dee45ea7",
                column: "ConcurrencyStamp",
                value: "9e58110b-d30c-4000-8a32-627b34669390");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8815f0d6-db8e-4606-8acb-12844e7b796b",
                column: "ConcurrencyStamp",
                value: "d103e61f-4438-41ef-bc95-9bdb8c344cc4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d140eb54-ed6e-4ff2-9199-71fcbe722ef7",
                column: "ConcurrencyStamp",
                value: "4f28d5f1-8ecd-4993-b87d-d78745c3a982");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de820986-a707-4cc5-8306-776812617837",
                column: "ConcurrencyStamp",
                value: "f987a102-6617-4a41-942b-dd9e258f6c16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "256ac0cc-c4b0-458d-957d-24cbfd49225b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8c92822-49de-421e-ba52-4ba5c849564b", "AQAAAAIAAYagAAAAEG7IXrzp305EfQ5vEBnuyZnNwVLlwDnvo0idTXy5HA5F5OzsED3ve7QpndZ0JzgMsw==", "b1cfbfd2-952d-4ec9-b675-ae1e64031fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade9cc9-9152-4209-ae22-f2e9e57b09a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "631ed5f6-bbd2-4fbf-a5e1-80c6fcb1bd09", "AQAAAAIAAYagAAAAEGSkRRiqTNM8biSQQiQk0PNMKGN+4TTraNbmFL/8nJxP8E3nXkSe44GzJkktozXbSA==", "abfacf88-faec-44d4-accc-c0a4a38ea02f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb49ce85-c5c9-41d9-9665-321d430b7e2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53bc9fd-dad4-43cc-95fc-7aaba0db71df", "AQAAAAIAAYagAAAAEJgIgueFytBstbyUKjMLmAWBiyKUBOxN4xILnOk/giL/B04p7rrDHHm0H+QG3rP7fA==", "7aecce23-896a-4cba-8fec-18933cba9cc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7ebd93d-0642-4ab9-8da3-4b6b2046e540",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ef5b2c-1b9d-4070-97c7-1fd7dca0d75d", "AQAAAAIAAYagAAAAEGnOkIyCqyUnGs14mersDVJfdvE5Ja5kUh3smc62qy3tSWUbofqZFLsKqQ2gigOUNA==", "845287f3-02d3-49ce-b28b-6a79dd2b84af" });
        }
    }
}
