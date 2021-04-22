using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyDev.Domain.Data.Migrations
{
    public partial class addedBlogs_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 2, "Wrapt Dev", 1, "https://wrapt.dev/feed.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 3, "Codeopinion", 1, "https://codeopinion.com/feed/" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 4, "Dev Blogs", 1, "https://devblogs.microsoft.com/dotnet/feed/" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 5, "Developers Redhat", 1, "https://developers.redhat.com/blog/feed/" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 6, "Rehansaeed", 1, "https://rehansaeed.com/rss.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 7, "Red Gate", 1, "https://www.red-gate.com/simple-talk/feed/" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 8, "Channel 9", 1, "https://s.ch9.ms/Feeds/RSS" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 9, "Rick Strahl", 1, "http://feeds.feedburner.com/rickstrahl" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 10, "Lizzy Gallagher", 1, "https://lizzy-gallagher.github.io/feed.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 11, "AzureTipsAndTricks", 1, "https://microsoft.github.io/AzureTipsAndTricks/rss.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 12, "Haacked", 1, "http://feeds.haacked.com/haacked" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 13, "Diogo Monica", 1, "https://feedly.com/i/subscription/feed%2Fhttps%3A%2F%2Fdiogomonica.com%2Frss%2F" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 14, "Andrewlock", 1, "https://andrewlock.net/rss.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 15, "Aspnetmonsters", 1, "https://www.aspnetmonsters.com/atom.xml" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 16, "Dusted", 1, "https://dusted.codes/feed/rss" });

            migrationBuilder.InsertData(
                table: "SiteModels",
                columns: new[] { "Id", "Name", "Priority", "Url" },
                values: new object[] { 17, "TroyHunt", 1, "https://feeds.feedburner.com/TroyHunt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SiteModels",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
