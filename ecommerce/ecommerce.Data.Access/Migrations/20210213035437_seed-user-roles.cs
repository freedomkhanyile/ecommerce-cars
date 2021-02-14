using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class seeduserroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Manufacturers_ManufacturerEntityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ManufacturerEntityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ManufacturerEntityId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "RoleName", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 13, 5, 54, 36, 374, DateTimeKind.Local).AddTicks(9422), "System", new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(6220), "System", "Admin", 1 },
                    { 2, new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(7954), "System", new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(7975), "System", "Manufacturer", 1 },
                    { 3, new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(8005), "System", new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(8006), "System", "Customer", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "CreateUserId", "Email", "FirstName", "ModifyDate", "ModifyUserId", "Password", "PhoneNumber", "StatusId", "Surname", "UserToken" },
                values: new object[] { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"), new DateTime(2021, 2, 13, 5, 54, 36, 550, DateTimeKind.Local).AddTicks(8903), "System", "admin@mail.com", "john", new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(746), "System", "$2a$11$M5jPDbORZqlPeArBA9Nygu/LuSahHOkaG2y07UXqKJsY94aM3adXW", null, 1, "Doe", null });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "RoleEntityId", "StatusId", "UserEntityId" },
                values: new object[] { 1, new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(7336), "System", new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(7345), "System", 1, 1, new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"));

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerEntityId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManufacturerEntityId",
                table: "Users",
                column: "ManufacturerEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Manufacturers_ManufacturerEntityId",
                table: "Users",
                column: "ManufacturerEntityId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
