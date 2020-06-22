using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeRegistrationPOC.Migrations
{
    public partial class changednamefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Employee",
                newName: "Lname");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Employee",
                newName: "Fname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lname",
                table: "Employee",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "Fname",
                table: "Employee",
                newName: "FName");
        }
    }
}
