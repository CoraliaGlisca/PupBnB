using Microsoft.EntityFrameworkCore.Migrations;

namespace PupBnB.EFDataAccess.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Dogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Dogs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
