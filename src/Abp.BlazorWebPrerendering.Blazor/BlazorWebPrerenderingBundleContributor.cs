using Volo.Abp.Bundling;

namespace Abp.BlazorWebPrerendering.Blazor
{
    public class BlazorWebPrerenderingBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {

        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css");
        }
    }
}
