using Abp.BlazorWebPrerendering.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.BlazorWebPrerendering.Blazor
{
    public abstract class BlazorWebPrerenderingComponentBase : AbpComponentBase
    {
        protected BlazorWebPrerenderingComponentBase()
        {
            LocalizationResource = typeof(BlazorWebPrerenderingResource);
        }
    }
}
