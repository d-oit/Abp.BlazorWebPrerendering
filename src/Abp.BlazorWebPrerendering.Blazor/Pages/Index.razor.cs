using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Abp.BlazorWebPrerendering.Blazor.Pages
{
    public partial class Index 
    {
        protected override async Task OnInitializedAsync()
        {
            Logger.LogDebug("Index OnInitializedAsync");
        }
    }
}
