using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyDev.Domain.Data.Migrations
{
    public partial class priority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "SiteModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 1, "Code Maze", 1, "https://code-maze.com/feed/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "SiteModels");
        }
    }
}
