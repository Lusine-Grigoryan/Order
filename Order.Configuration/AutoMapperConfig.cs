using AutoMapper;
using Order.Common.Models;
using Order.DAL.Models;
using System;

namespace Order.Configuration
{
    public static class AutoMapperConfig
    {
        private static Mapper _mapper;

        public static Mapper Instance
        {
            get
            {
                if (_mapper == null)
                {
                    Register();
                }

                return _mapper;
            }
        }

        public static void Register()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Provider, ProviderUIModel>();
                cfg.CreateMap<State, StateUIModel>();
            });

            _mapper = new Mapper(config);
        }
    }
}
