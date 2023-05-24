using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBetBiga.Migrations
{
    public partial class Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution");

            migrationBuilder.DropIndex(
                name: "IX_AdminEquipmentDistribution_CategoryId",
                table: "AdminEquipmentDistribution");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "AdminEquipmentDistribution");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "AdminEquipmentDistribution",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdminEquipmentDistribution_CategoryId",
                table: "AdminEquipmentDistribution",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
