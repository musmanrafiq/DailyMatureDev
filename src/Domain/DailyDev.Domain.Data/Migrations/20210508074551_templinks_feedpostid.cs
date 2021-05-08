using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyDev.Domain.Data.Migrations
{
    public partial class templinks_feedpostid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeedPostId",
                table: "TempLinks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedPostId",
                table: "TempLinks");
        }
    }
}
