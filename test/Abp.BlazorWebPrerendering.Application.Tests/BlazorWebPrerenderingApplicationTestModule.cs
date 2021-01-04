using Volo.Abp.Modularity;

namespace Abp.BlazorWebPrerendering
{
    [DependsOn(
        typeof(BlazorWebPrerenderingApplicationModule),
        typeof(BlazorWebPrerenderingDomainTestModule)
        )]
    public class BlazorWebPrerenderingApplicationTestModule : AbpModule
    {

    }
}