using Abp.BlazorWebPrerendering.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.BlazorWebPrerendering.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlazorWebPrerenderingController : AbpController
    {
        protected BlazorWebPrerenderingController()
        {
            LocalizationResource = typeof(BlazorWebPrerenderingResource);
        }
    }
}