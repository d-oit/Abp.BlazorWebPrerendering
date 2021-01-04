using Abp.BlazorWebPrerendering.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.BlazorWebPrerendering.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BlazorWebPrerenderingEntityFrameworkCoreDbMigrationsModule),
        typeof(BlazorWebPrerenderingApplicationContractsModule)
        )]
    public class BlazorWebPrerenderingDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
