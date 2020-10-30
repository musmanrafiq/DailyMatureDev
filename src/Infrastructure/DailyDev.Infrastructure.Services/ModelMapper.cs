using AutoMapper;
using CodeHollow.FeedReader;
using DailyDev.Domain.Business.Models;

namespace DailyDev.Infrastructure.Services
{
    public static class ModelMapper
    {
        private static IMapper mapper;
        public static IMapper Init()
        {
            if (mapper == null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Feed, FeedModel>().ReverseMap();
                    cfg.CreateMap<FeedItem, FeedItemModel>().ReverseMap();
                });
                mapper = config.CreateMapper();
            }
            return mapper;
        }
    }
}
