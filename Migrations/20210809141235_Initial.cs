using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace LocalBetBiga.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 72, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 72, nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EquipmentType = table.Column<string>(nullable: false),
                    NumberInStore = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminEquipmentDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    EquipmentsId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTime>(nullable: false),
                    NumberOfEquipmentAssigned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminEquipmentDistribution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminEquipmentDistribution_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminEquipmentDistribution_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminEquipmentDistribution_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerEquipmentDistribution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EquipmentId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    NameOfAgentAssignedTo = table.Column<string>(nullable: true),
                    NumberOfEquipmentAssigned = table.Column<int>(nullable: false),
                    ShopAddress = table.Column<string>(nullable: true),
                    DateAssigned = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerEquipmentDistribution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerEquipmentDistribution_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerEquipmentDistribution_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminEquipmentDistribution_AdminId",
                table: "AdminEquipmentDistribution",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminEquipmentDistribution_CategoryId",
                table: "AdminEquipmentDistribution",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminEquipmentDistribution_EquipmentsId",
                table: "AdminEquipmentDistribution",
                column: "EquipmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminEquipmentDistribution_ManagerId",
                table: "AdminEquipmentDistribution",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CategoryId",
                table: "Equipments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerEquipmentDistribution_EquipmentId",
                table: "ManagerEquipmentDistribution",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerEquipmentDistribution_ManagerId",
                table: "ManagerEquipmentDistribution",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminEquipmentDistribution");

            migrationBuilder.DropTable(
                name: "ManagerEquipmentDistribution");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
