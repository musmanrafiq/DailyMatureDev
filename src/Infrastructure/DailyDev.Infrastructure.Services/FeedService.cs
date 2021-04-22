using CodeHollow.FeedReader;
using DailyDev.Domain.Business.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DailyDev.Infrastructure.Services
{
    public class FeedService
    {
        public async Task<(FeedModel, string)> FetchAsync(string url)
        {
            try
            {
                var feed = await FeedReader.ReadAsync(url);
                var mapper = ModelMapper.Init();

                foreach (var feedItems in feed.Items)
                {
                    if (string.IsNullOrEmpty(feedItems.Author))
                    {
                        var xele = feedItems.SpecificItem.Element.Descendants().ToList();
                        var author = xele.Where(x => x.Name.LocalName == "creator").Select(x =>
                         x.Value
                        ).FirstOrDefault();
                        if (author != null)
                        {
                            feedItems.Author = author;
                        }
                    }
                }
                var FeedModel = mapper.Map<Feed, FeedModel>(feed);
                return (FeedModel, string.Empty);
            }
            catch (Exception exp)
            {
                return (null, exp.Message);

            }

        }

        public async Task<(FeedItemModel, string)> FetchLatestPost(string url)
        {
            try
            {
                var feed = await FeedReader.ReadAsync(url);
                var feedItem = feed.Items.FirstOrDefault();
                var mapper = ModelMapper.Init();
                var feedItemModel = mapper.Map<FeedItem, FeedItemModel>(feedItem);

                return (feedItemModel, string.Empty);
            }
            catch (Exception exp)
            {
                return (null, exp.Message);

            }

        }
    }
}
