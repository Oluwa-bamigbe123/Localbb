using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace LocalBetBiga.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TotalSales = table.Column<string>(nullable: true),
                    TotalWinnings = table.Column<string>(nullable: true),
                    TotalGGR = table.Column<string>(nullable: true),
                    Commission = table.Column<string>(nullable: true),
                    NGR = table.Column<string>(nullable: true),
                    ProjectedSales = table.Column<string>(nullable: true),
                    ActualSales = table.Column<string>(nullable: true),
                    PecentageOfSalesComparedToProjectedSales = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
