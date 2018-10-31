using Microsoft.EntityFrameworkCore.Migrations;

namespace NLightHouse.Migrations
{
    public partial class AddCanceledPropertyToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Canceled",
                table: "Projects",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Canceled",
                table: "Projects");
        }
    }
}
