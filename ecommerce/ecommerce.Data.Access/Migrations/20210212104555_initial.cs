using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerce.Data.Access.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IsLegalEntity = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ManufacturerName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    StockInHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    StatusName = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    VehicleEntityId = table.Column<Guid>(nullable: false),
                    OptionEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ManufacturerEntityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Manufacturers_ManufacturerEntityId",
                        column: x => x.ManufacturerEntityId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserToken = table.Column<string>(nullable: true),
                    ManufacturerEntityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Manufacturers_ManufacturerEntityId",
                        column: x => x.ManufacturerEntityId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ModelName = table.Column<string>(nullable: true),
                    ModelYear = table.Column<string>(nullable: true),
                    BodyStyle = table.Column<string>(nullable: true),
                    ManufacturerEntityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Manufacturers_ManufacturerEntityId",
                        column: x => x.ManufacturerEntityId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUserId = table.Column<string>(maxLength: 256, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 256, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    UserEntityId = table.Column<Guid>(nullable: false),
                    RoleEntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleEntityId",
                        column: x => x.RoleEntityId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_ManufacturerEntityId",
                table: "Options",
                column: "ManufacturerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleEntityId",
                table: "UserRoles",
                column: "RoleEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserEntityId",
                table: "UserRoles",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManufacturerEntityId",
                table: "Users",
                column: "ManufacturerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ManufacturerEntityId",
                table: "Vehicles",
                column: "ManufacturerEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "VehicleOptions");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
