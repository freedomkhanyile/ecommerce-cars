using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class update_tables_migration_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "OrderLines",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251566"),
                columns: new[] { "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "StatusId" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 900, DateTimeKind.Local).AddTicks(28), "System", new DateTime(2021, 2, 14, 23, 7, 15, 900, DateTimeKind.Local).AddTicks(46), "System", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251586"),
                columns: new[] { "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "StatusId" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 900, DateTimeKind.Local).AddTicks(185), "System", new DateTime(2021, 2, 14, 23, 7, 15, 900, DateTimeKind.Local).AddTicks(187), "System", 1 });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4033), new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4021), new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(3910), new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4027), new DateTime(2021, 2, 14, 23, 7, 15, 897, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2836), new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2979), new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2986), new DateTime(2021, 2, 14, 23, 7, 15, 898, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 711, DateTimeKind.Local).AddTicks(7414), new DateTime(2021, 2, 14, 23, 7, 15, 713, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 713, DateTimeKind.Local).AddTicks(8306), new DateTime(2021, 2, 14, 23, 7, 15, 713, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 713, DateTimeKind.Local).AddTicks(8360), new DateTime(2021, 2, 14, 23, 7, 15, 713, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 896, DateTimeKind.Local).AddTicks(5055), new DateTime(2021, 2, 14, 23, 7, 15, 896, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 895, DateTimeKind.Local).AddTicks(7103), new DateTime(2021, 2, 14, 23, 7, 15, 895, DateTimeKind.Local).AddTicks(8516), "$2a$11$gSSymwRlcg0ZdUCMlJChSef21OqtieB7.N3Cp50stoCuHloDjiQDO" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4213251566"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1592), new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251555"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1478), new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251566"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1584), new DateTime(2021, 2, 14, 23, 7, 15, 899, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOptions_OptionEntityId",
                table: "VehicleOptions",
                column: "OptionEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOptions_Options_OptionEntityId",
                table: "VehicleOptions",
                column: "OptionEntityId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleOptions_Options_OptionEntityId",
                table: "VehicleOptions");

            migrationBuilder.DropIndex(
                name: "IX_VehicleOptions_OptionEntityId",
                table: "VehicleOptions");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderLines");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251566"),
                columns: new[] { "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "StatusId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251586"),
                columns: new[] { "CreateDate", "CreateUserId", "ModifyDate", "ModifyUserId", "StatusId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0 });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc3237251336"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3197), new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251235"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3184), new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3059), new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237261335"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3192), new DateTime(2021, 2, 14, 16, 28, 31, 66, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1225), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1306), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1311), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 30, 888, DateTimeKind.Local).AddTicks(5326), new DateTime(2021, 2, 14, 16, 28, 30, 890, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 30, 890, DateTimeKind.Local).AddTicks(6328), new DateTime(2021, 2, 14, 16, 28, 30, 890, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 30, 890, DateTimeKind.Local).AddTicks(6385), new DateTime(2021, 2, 14, 16, 28, 30, 890, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 65, DateTimeKind.Local).AddTicks(5263), new DateTime(2021, 2, 14, 16, 28, 31, 65, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                columns: new[] { "CreateDate", "ModifyDate", "Password" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 64, DateTimeKind.Local).AddTicks(7702), new DateTime(2021, 2, 14, 16, 28, 31, 64, DateTimeKind.Local).AddTicks(9194), "$2a$11$zT0N8cYrZnX65rUdkNN.jOpy2sZ4kZ7WfX6bGBiBjwvmy18asWp3u" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4213251566"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8088), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251555"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8006), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251566"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8081), new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8083) });
        }
    }
}
