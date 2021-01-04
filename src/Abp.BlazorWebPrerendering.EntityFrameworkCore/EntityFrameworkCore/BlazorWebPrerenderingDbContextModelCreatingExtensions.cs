using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Abp.BlazorWebPrerendering.EntityFrameworkCore
{
    public static class BlazorWebPrerenderingDbContextModelCreatingExtensions
    {
        public static void ConfigureBlazorWebPrerendering(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BlazorWebPrerenderingConsts.DbTablePrefix + "YourEntities", BlazorWebPrerenderingConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}