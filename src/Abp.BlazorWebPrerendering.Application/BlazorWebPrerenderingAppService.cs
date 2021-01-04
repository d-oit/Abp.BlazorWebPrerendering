using System;
using System.Collections.Generic;
using System.Text;
using Abp.BlazorWebPrerendering.Localization;
using Volo.Abp.Application.Services;

namespace Abp.BlazorWebPrerendering
{
    /* Inherit your application services from this class.
     */
    public abstract class BlazorWebPrerenderingAppService : ApplicationService
    {
        protected BlazorWebPrerenderingAppService()
        {
            LocalizationResource = typeof(BlazorWebPrerenderingResource);
        }
    }
}
