using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Abp.BlazorWebPrerendering.EntityFrameworkCore
{
    [DependsOn(
        typeof(BlazorWebPrerenderingEntityFrameworkCoreModule)
        )]
    public class BlazorWebPrerenderingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BlazorWebPrerenderingMigrationsDbContext>();
        }
    }
}
