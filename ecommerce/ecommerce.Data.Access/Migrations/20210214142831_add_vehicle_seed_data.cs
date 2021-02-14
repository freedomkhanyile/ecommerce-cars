using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class add_vehicle_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "AnnualIncome", "City", "CreateDate", "CreateUserId", "Email", "FirstName", "IsLegalEntity", "ModifyDate", "ModifyUserId", "PhoneNumber", "StatusId", "Surname" },
                values: new object[,]
                {
                    { new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251566"), "Randpark Ridge, House street", 900000.0, "Johannesburg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "freedom.khanyile@mail.com", "Freedom", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "07455658457", 0, "Khanyile" },
                    { new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251586"), "Mine park, Mines street", 90000000.0, "Johannesburg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "info@goldman-mines.com", "Goldman Mines", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0112457854", 0, null }
                });

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

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyStyle", "CreateDate", "CreateUserId", "ManufacturerEntityId", "ModelName", "ModelYear", "ModifyDate", "ModifyUserId", "StatusId" },
                values: new object[,]
                {
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251566"), "Sedan", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8081), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"), "BMW M3", "2021", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8083), "System", 1 },
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc4213251566"), "Coupe", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8088), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"), "Mercedes Benz C63 AMG", "2021", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8089), "System", 1 },
                    { new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251555"), "Hot Hatchback", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8006), "System", new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251445"), "VW Golf GTI 7", "2021", new DateTime(2021, 2, 14, 16, 28, 31, 67, DateTimeKind.Local).AddTicks(8017), "System", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251566"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ff5641f7-ce8d-4de5-aef7-bc4213251586"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4213251566"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251555"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c6e641f7-ce8d-4de5-aef7-bc4237251566"));

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
        }
    }
}
