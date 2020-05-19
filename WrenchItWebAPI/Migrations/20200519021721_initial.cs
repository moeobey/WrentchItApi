using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchItWebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(nullable: true),
                    EstimatedTimeToComplete = table.Column<double>(nullable: false),
                    Labor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "EstimatedTimeToComplete", "Labor", "ServiceName" },
                values: new object[,]
                {
                    { 1, 0.5, 30.0, "Oil Change" },
                    { 2, 1.5, 30.0, "Head Gasket" },
                    { 3, 1.0, 30.0, "Brake Pads" },
                    { 4, 2.5, 30.0, "Exhaust" },
                    { 5, 2.0, 30.0, "Struts" },
                    { 6, 1.0, 30.0, "Spark Plugs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
