using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyDev.Domain.Data.Migrations
{
    public partial class site_name_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SiteModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SiteModels");
        }
    }
}
