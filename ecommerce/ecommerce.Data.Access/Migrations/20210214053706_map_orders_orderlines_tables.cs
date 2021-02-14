using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class map_orders_orderlines_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerEntityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerEntityId",
                        column: x => x.CustomerEntityId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ProductId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    IsAssembling = table.Column<bool>(nullable: false),
                    OrderEntityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2728), new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2711), new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2611), new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2721), new DateTime(2021, 2, 14, 7, 37, 6, 119, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(969), new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(1050), new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(1057), new DateTime(2021, 2, 14, 7, 37, 6, 120, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 5, 916, DateTimeKind.Local).AddTicks(3608), new DateTime(2021, 2, 14, 7, 37, 5, 918, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 5, 918, DateTimeKind.Local).AddTicks(7132), new DateTime(2021, 2, 14, 7, 37, 5, 918, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 5, 918, DateTimeKind.Local).AddTicks(7186), new DateTime(2021, 2, 14, 7, 37, 5, 918, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 118, DateTimeKind.Local).AddTicks(4685), new DateTime(2021, 2, 14, 7, 37, 6, 118, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 37, 6, 117, DateTimeKind.Local).AddTicks(6682), new DateTime(2021, 2, 14, 7, 37, 6, 117, DateTimeKind.Local).AddTicks(8212), "$2a$11$Fe2XetkMatAKpTyEopEEQOfCpwsRIDBG2RSjGZSgItrJNsJPBfNnS" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderEntityId",
                table: "OrderLines",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerEntityId",
                table: "Orders",
                column: "CustomerEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9900), new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9546), new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9281), new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9687), new DateTime(2021, 2, 14, 7, 31, 21, 786, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1156), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1398), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1517), new DateTime(2021, 2, 14, 7, 31, 21, 788, DateTimeKind.Local).AddTicks(1558) });

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
        }
    }
}
