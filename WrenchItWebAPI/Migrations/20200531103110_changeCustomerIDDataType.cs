using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchItWebAPI.Migrations
{
    public partial class changeCustomerIDDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Services",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Services",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
