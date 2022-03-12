using Microsoft.EntityFrameworkCore.Migrations;
using microsvc.services.Infrastruture;
using System.IO;

namespace microsvc.services.Migrations.userdb
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppConstants.UserMigrationBasePath, "20220311235553_seed-data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppConstants.UserMigrationBasePath, "20220311235553_seed-data-reverse.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }
    }
}
