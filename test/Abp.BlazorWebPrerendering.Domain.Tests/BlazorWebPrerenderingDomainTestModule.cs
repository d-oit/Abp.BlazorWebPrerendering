using Abp.BlazorWebPrerendering.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.BlazorWebPrerendering
{
    [DependsOn(
        typeof(BlazorWebPrerenderingEntityFrameworkCoreTestModule)
        )]
    public class BlazorWebPrerenderingDomainTestModule : AbpModule
    {

    }
}