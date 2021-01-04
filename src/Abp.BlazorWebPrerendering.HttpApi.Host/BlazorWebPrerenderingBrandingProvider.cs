using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.BlazorWebPrerendering
{
    [Dependency(ReplaceServices = true)]
    public class BlazorWebPrerenderingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BlazorWebPrerendering";
    }
}
