using AutoMapper;

namespace WholesaleMarketHall.Web.MediatR.Application.Mapping
{
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> mapper = new(() =>
        {
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            return conf.CreateMapper();
        });

        public static IMapper Mapper => mapper.Value;
    }
}
