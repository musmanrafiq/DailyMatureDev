using AutoMapper;
using DailyDev.Domain.Business.Models;

namespace DailyDev.Domain.Business.Mapping
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
                    cfg.CreateMap<SiteModel, Domain.Models.SiteModel>();
                });
                mapper = config.CreateMapper();
            }
            return mapper;
        }
    }
}
