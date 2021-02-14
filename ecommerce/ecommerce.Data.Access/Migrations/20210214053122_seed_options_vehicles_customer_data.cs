using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class seed_options_vehicles_customer_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Options",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "QtyStock",
                table: "Options",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Manufacturers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate", "Type" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9281), new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9344), "Main Office" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Address", "CreateDate", "CreateUserId", "ManufacturerName", "ModifyDate", "ModifyUserId", "StatusId", "StockInHand", "Telephone", "Type" },
                values: new object[,]
                {
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"), "New Land, Factory street", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9546), "System", "Volivo Factory 1", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9590), "System", 1, 99, "01245487541", "Factory" },
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"), "New Land, Factory street 2", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9687), "System", "Volivo Factory 2", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9729), "System", 1, 99, "01401245122", "Factory" },
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"), "New Land, Warehouse Street 900", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9900), "System", "Volivo Warehouse", new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9942), "System", 1, 99, "01401245122", "WareHouse" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 568, DateTimeKind.Local).AddTicks(7603), new DateTime(2021, 2, 14, 7, 31, 21, 571, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 571, DateTimeKind.Local).AddTicks(9442), new DateTime(2021, 2, 14, 7, 31, 21, 571, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 571, DateTimeKind.Local).AddTicks(9540), new DateTime(2021, 2, 14, 7, 31, 21, 571, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 785, DateTimeKind.Local).AddTicks(8928), new DateTime(2021, 2, 14, 7, 31, 21, 785, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 784, DateTimeKind.Local).AddTicks(8490), new DateTime(2021, 2, 14, 7, 31, 21, 785, DateTimeKind.Local).AddTicks(163), "$2a$11$XP/bBuCSIZTI/avsGFwu3.bixGANw5gidl88Bw/WHAIY/lndJBZm." });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "ManufacturerEntityId", "ModifyDate", "ModifyUserId", "Name", "Price", "QtyStock", "StatusId", "Value" },
                values: new object[] { 1, "ENG-COMP", new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1156), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1223), "System", "Engine", 9000.0, 10, 1, "V12 Engine" });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "ManufacturerEntityId", "ModifyDate", "ModifyUserId", "Name", "Price", "QtyStock", "StatusId", "Value" },
                values: new object[] { 2, "CHA-COMP", new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1398), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1440), "System", "Chasis", 10000.0, 10, 1, "Ladder Frame" });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Code", "CreateDate", "CreateUserId", "ManufacturerEntityId", "ModifyDate", "ModifyUserId", "Name", "Price", "QtyStock", "StatusId", "Value" },
                values: new object[] { 3, "OPT-COMP", new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1517), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1558), "System", "Option Pack", 5000.0, 10, 1, "Performance Package" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"));

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"));

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "QtyStock",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Manufacturers");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 376, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 2, 13, 6, 3, 31, 377, DateTimeKind.Local).AddTicks(61) });

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
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(3873), new DateTime(2021, 2, 13, 6, 3, 31, 537, DateTimeKind.Local).AddTicks(3963), "$2a$11$fE773XZlpjqf1kD4ImgM.OG/QPqNC7c98ecyR3UENkdyqaW5BYphm" });
        }
    }
}
