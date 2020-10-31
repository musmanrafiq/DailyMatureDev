using CodeHollow.FeedReader;
using DailyDev.Domain.Business.Models;
using System;
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
                var FeedModel = mapper.Map<Feed, FeedModel>(feed);
                return (FeedModel, string.Empty);
            }
            catch (Exception exp)
            {
                return (null, exp.Message);

            }

        }
    }
}
