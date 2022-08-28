using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Order.BLL.Interfaces;
using Order.BLL.Services;
using Order.DAL.Models;
using Order.DAL.Repositories;
using Order.Shared.Interfaces;
using System;

namespace Order.Server.Configuration
{
    public class SimpleInjectorConfig
    {
        //TODO FIX
        public static void RegisterServices(ref WebAssemblyHostBuilder builder)
        {
           builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();
           builder.Services.AddSingleton<IRepository<Provider>, Repository<Provider>>();
           builder.Services.AddSingleton<IProviderRepository, ProviderRepository>();
           builder.Services.AddSingleton<IProviderService, ProviderService>();
           builder.Services.AddSingleton<IStateRepository, StateRepository>();
        }
    }
}
