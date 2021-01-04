using System.Threading.Tasks;

namespace Abp.BlazorWebPrerendering.Data
{
    public interface IBlazorWebPrerenderingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
