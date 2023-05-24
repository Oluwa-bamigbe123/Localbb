using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBetBiga.Migrations
{
    public partial class fff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "adminId",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "managerId",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_adminId",
                table: "Sales",
                column: "adminId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_managerId",
                table: "Sales",
                column: "managerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Admins_adminId",
                table: "Sales",
                column: "adminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Managers_managerId",
                table: "Sales",
                column: "managerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Admins_adminId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Managers_managerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_adminId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_managerId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "adminId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "managerId",
                table: "Sales");
        }
    }
}
