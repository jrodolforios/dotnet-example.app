using Dotnet.ExampleApp.Application.Services;
using Dotnet.ExampleApp.Application.Services.Interfaces;
using Dotnet.ExampleApp.Domain.Configuration;
using Dotnet.ExampleApp.Infra.Context;
using Dotnet.ExampleApp.Infra.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Dotnet.ExampleApp.Setup
{
    [ExcludeFromCodeCoverage]
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection Bootstrap(this IServiceCollection services, IConfiguration configuration)
        {
            var configApp = configuration.Get<Configuration>();

            try
            {
                services.AddDbContext<ModelContext>(options => options.UseInMemoryDatabase("CarDatabase"));
            }
            catch (Exception e)
            {
                throw e;
            }

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<ICarsService, CarsService>();

            services.AddSingleton(configuration.Get<Configuration>());

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;

        }
    }
}