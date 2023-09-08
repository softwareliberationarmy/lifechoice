using System.Runtime.CompilerServices;
using Application.Core;
using Application.WeighIn;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configuration
{
    public static class ApplicationSetup
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(List.Query)));
            services.AddAutoMapper(cfg => cfg.AddMaps(typeof(MappingProfiles).Assembly));
            return services;
        }
    }
}
