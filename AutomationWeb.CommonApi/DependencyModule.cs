using System.Linq;
using AutomationWeb.Common.BL;
using AutomationWeb.Common.BL.Contract;
using AutomationWeb.Common.DAL;
using AutomationWeb.Common.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace AutomationWeb.Common.Api
{
    public static class DependencyModule
    {
        public static void RegisterTo(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var contextFactory = new RepositoryContextFactory(configuration);
            serviceCollection.AddScoped(provider => contextFactory.CreateDbContext());
            serviceCollection.AddScoped<IRepository, Repository>();

            serviceCollection.AddScoped<IOrderLogic, OrderLogic>();

            if (configuration.GetChildren().Any(item => item.Key == "Serilog"))
            {
                Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
                serviceCollection.AddScoped<ILog, SeriLogger>();
            }

            //var mappingConfig = new MapperConfiguration(mc =>
            //{
            //    mc.AddProfile(new DtoMapperProfile());
            //    mc.AddProfile(new BlMapperProfile());
            //});

            //var mapper = mappingConfig.CreateMapper();
            //serviceCollection.AddSingleton(mapper);
        }
    }
}