using CodeHollow.FeedReader;
using DailyDev.Domain.Business.Models;
using System.Threading.Tasks;

namespace DailyDev.Infrastructure.Services
{
    public class FeedService
    {
        public async Task<FeedModel> FetchAsync(string url)
        {
            var feed = await FeedReader.ReadAsync(url);
            var mapper = ModelMapper.Init();
            var FeedModel = mapper.Map<Feed, FeedModel>(feed);
            return FeedModel;
        }
    }
}
