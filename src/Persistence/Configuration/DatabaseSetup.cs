using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Logging;

namespace Persistence.Configuration
{
    public static class DatabaseSetup
    {
        public static async Task UpdateDatabase(this IServiceProvider services)
        {
            try
            {
                var context = services.GetRequiredService<DataContext>();
                await context.Database.MigrateAsync().ConfigureAwait(false);
                await Seed.SeedData(context).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<DataContext>>();
                logger.LogMigrationFailure(ex);
                throw;
            }

        }

        public static void AddDataContext(this IServiceCollection serviceCollection, IConfiguration builderConfiguration)
        {
            serviceCollection.AddDbContext<DataContext>(opts =>
            {
                opts.UseSqlite(builderConfiguration.GetConnectionString("DefaultConnection"));
            });

        }
    }

}
