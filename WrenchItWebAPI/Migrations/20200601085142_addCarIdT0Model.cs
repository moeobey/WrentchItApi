using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchItWebAPI.Migrations
{
    public partial class addCarIdT0Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Services",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Services");
        }
    }
}
