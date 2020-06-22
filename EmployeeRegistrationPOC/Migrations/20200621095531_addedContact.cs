using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeRegistrationPOC.Migrations
{
    public partial class addedContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Contact",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Employee");
        }
    }
}
