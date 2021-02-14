using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class usermanufacturerrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerEntityId",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Address", "CreateDate", "CreateUserId", "ManufacturerName", "ModifyDate", "ModifyUserId", "StatusId", "StockInHand", "Telephone" },
                values: new object[] { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"), "New Land, Car Street 900", new DateTime(2021, 2, 13, 6, 3, 31, 376, DateTimeKind.Local).AddTicks(8915), "System", "Volivo Motors", new DateTime(2021, 2, 13, 6, 3, 31, 377, DateTimeKind.Local).AddTicks(61), "System", 1, 99, "01401245122" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 372, DateTimeKind.Local).AddTicks(4352), new DateTime(2021, 2, 13, 6, 3, 31, 374, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 374, DateTimeKind.Local).AddTicks(4123), new DateTime(2021, 2, 13, 6, 3, 31, 374, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 374, DateTimeKind.Local).AddTicks(4223), new DateTime(2021, 2, 13, 6, 3, 31, 374, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(9390), new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ManufacturerEntityId", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(3873), new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"), new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(3963), "$2a$11$fE773XZlpjqf1kD4ImgM.OG/QPqNC7c98ecyR3UENkdyqaW5BYphm" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Manufacturers_ManufacturerEntityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ManufacturerEntityId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"));

            migrationBuilder.DropColumn(
                name: "ManufacturerEntityId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 5, 54, 36, 374, DateTimeKind.Local).AddTicks(9422), new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(7954), new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(8005), new DateTime(2021, 2, 13, 5, 54, 36, 376, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(7336), new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 13, 5, 54, 36, 550, DateTimeKind.Local).AddTicks(8903), new DateTime(2021, 2, 13, 5, 54, 36, 551, DateTimeKind.Local).AddTicks(746), "$2a$11$M5jPDbORZqlPeArBA9Nygu/LuSahHOkaG2y07UXqKJsY94aM3adXW" });
        }
    }
}
