using DailyDev.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DailyDev.Domain.Data.Seeders
{

    public class BlogsSeeder : IEntityTypeConfiguration<SiteModel>
    {
        public void Configure(EntityTypeBuilder<SiteModel> builder)
        {

            builder.ToTable("SiteModels");

            builder.HasData
            (
                new SiteModel
                {
                    Id = 1,
                    Name = "Code Maze",
                    Url = "https://code-maze.com/feed/"
                },
                new SiteModel
                {
                    Id = 2,
                    Name = "Wrapt Dev",
                    Url = "https://wrapt.dev/feed.xml"
                },
                new SiteModel
                {
                    Id = 3,
                    Name = "Codeopinion",
                    Url = "https://codeopinion.com/feed/",
                },
                new SiteModel
                {
                    Id = 4,
                    Name = "Dev Blogs",
                    Url = "https://devblogs.microsoft.com/dotnet/feed/"
                },
                new SiteModel
                {
                    Id = 5,
                    Name = "Developers Redhat",
                    Url = "https://developers.redhat.com/blog/feed/"
                },
                new SiteModel
                {
                    Id = 6,
                    Name = "Rehansaeed",
                    Url = "https://rehansaeed.com/rss.xml"
                },
                new SiteModel
                {
                    Id = 7,
                    Name = "Red Gate",
                    Url = "https://www.red-gate.com/simple-talk/feed/"
                },
                new SiteModel
                {
                    Id = 8,
                    Name = "Channel 9",
                    Url = "https://s.ch9.ms/Feeds/RSS"
                },
                new SiteModel
                {
                    Id = 9,
                    Name = "Rick Strahl",
                    Url = "http://feeds.feedburner.com/rickstrahl"
                },
                new SiteModel
                {
                    Id = 10,
                    Name = "Lizzy Gallagher",
                    Url = "https://lizzy-gallagher.github.io/feed.xml"
                },
                new SiteModel
                {
                    Id = 11,
                    Name = "AzureTipsAndTricks",
                    Url = "https://microsoft.github.io/AzureTipsAndTricks/rss.xml"
                },
                new SiteModel
                {
                    Id = 12,
                    Name = "Haacked",
                    Url = "http://feeds.haacked.com/haacked"
                },
                new SiteModel
                {
                    Id = 13,
                    Name = "Diogo Monica",
                    Url = "https://feedly.com/i/subscription/feed%2Fhttps%3A%2F%2Fdiogomonica.com%2Frss%2F"
                },
                new SiteModel
                {
                    Id = 14,
                    Name = "Andrewlock",
                    Url = "https://andrewlock.net/rss.xml"
                },
                new SiteModel
                {
                    Id = 15,
                    Name = "Aspnetmonsters",
                    Url = "https://www.aspnetmonsters.com/atom.xml"
                },
                new SiteModel
                {
                    Id = 16,
                    Name = "Dusted",
                    Url = "https://dusted.codes/feed/rss"
                },
                new SiteModel
                {
                    Id = 17,
                    Name = "TroyHunt",
                    Url = "https://feeds.feedburner.com/TroyHunt"
                }
            );

        }
    }
}
