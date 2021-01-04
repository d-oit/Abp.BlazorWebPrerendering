using Volo.Abp.Settings;

namespace Abp.BlazorWebPrerendering.Settings
{
    public class BlazorWebPrerenderingSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BlazorWebPrerenderingSettings.MySetting1));
        }
    }
}
