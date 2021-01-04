using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Abp.BlazorWebPrerendering.Data;
using Volo.Abp.DependencyInjection;

namespace Abp.BlazorWebPrerendering.EntityFrameworkCore
{
    public class EntityFrameworkCoreBlazorWebPrerenderingDbSchemaMigrator
        : IBlazorWebPrerenderingDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBlazorWebPrerenderingDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BlazorWebPrerenderingMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BlazorWebPrerenderingMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}