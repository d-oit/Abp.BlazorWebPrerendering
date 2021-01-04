using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.BlazorWebPrerendering.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BlazorWebPrerenderingMigrationsDbContextFactory : IDesignTimeDbContextFactory<BlazorWebPrerenderingMigrationsDbContext>
    {
        public BlazorWebPrerenderingMigrationsDbContext CreateDbContext(string[] args)
        {
            BlazorWebPrerenderingEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BlazorWebPrerenderingMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BlazorWebPrerenderingMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Abp.BlazorWebPrerendering.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
