﻿using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Configuration
{
    public static class DatabaseSetup
    {
        public static async Task UpdateDatabase(this IServiceProvider services)
        {
            try
            {
                var context = services.GetRequiredService<DataContext>();
                await context.Database.MigrateAsync();
                await Seed.SeedData(context);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<DataContext>>();
                logger.LogError(ex, "Error applying migrations to database");
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