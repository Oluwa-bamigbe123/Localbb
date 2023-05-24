using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBetBiga.Migrations
{
    public partial class RmvdCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AdminEquipmentDistribution",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "AdminEquipmentDistribution",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdminEquipmentDistribution_Category_CategoryId",
                table: "AdminEquipmentDistribution",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
