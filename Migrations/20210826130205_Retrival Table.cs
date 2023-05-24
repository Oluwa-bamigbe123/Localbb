using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace LocalBetBiga.Migrations
{
    public partial class RetrivalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Retrivals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    NameOfAgent = table.Column<string>(nullable: true),
                    NameOfEquipmentRetrieved = table.Column<string>(nullable: true),
                    DateRetrieved = table.Column<DateTime>(nullable: false),
                    NameOfAgentReassignedTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retrivals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Retrivals_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Retrivals_ManagerId",
                table: "Retrivals",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retrivals");
        }
    }
}
