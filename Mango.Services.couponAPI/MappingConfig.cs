using AutoMapper;
using Mango.Services.couponAPI.Models;
using Mango.Services.couponAPI.Models.Dto;

namespace Mango.Services.couponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
