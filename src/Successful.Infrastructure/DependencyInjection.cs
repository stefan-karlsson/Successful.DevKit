using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Successful.Application.Abstractions;
using Successful.Infrastructure.Providers;

namespace Successful.Infrastructure
{
    /// <summary>
    /// Class that makes it possible for other project to inject services
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Inject services needed to run the Persistence layer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns>ServiceCollection</returns>
        public static IServiceCollection UseInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDateTime, DateTimeProvider>();

            return services;
        }
    }
}