using Microsoft.EntityFrameworkCore.Migrations;

namespace microsvc.services.Migrations.orderdb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "int", nullable: false),
                    TotalSpent = table.Column<double>(nullable: true),
                    UserId = table.Column<long>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntity", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderEntity");
        }
    }
}
