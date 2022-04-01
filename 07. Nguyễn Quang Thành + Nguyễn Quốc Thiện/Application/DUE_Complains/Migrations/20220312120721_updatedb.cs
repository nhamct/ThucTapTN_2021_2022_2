using Microsoft.EntityFrameworkCore.Migrations;

namespace DUE_Complains.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_IdDepartmentNavigationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdDepartmentNavigationId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdDepartmentNavigationId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDepartmentNavigationId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdDepartmentNavigationId",
                table: "Employees",
                column: "IdDepartmentNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_IdDepartmentNavigationId",
                table: "Employees",
                column: "IdDepartmentNavigationId",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
