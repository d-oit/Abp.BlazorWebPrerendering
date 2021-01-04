﻿using System;
using System.Net.Http;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using IdentityModel;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.AspNetCore.Components.WebAssembly.BasicTheme;
using Volo.Abp.AspNetCore.Components.WebAssembly.BasicTheme.Themes.Basic;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.Autofac.WebAssembly;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.AutoMapper;
using Volo.Abp.TenantManagement.Blazor;
using Abp.BlazorWebPrerendering.Blazor.Menus;

namespace Abp.BlazorWebPrerendering.Blazor
{
    [DependsOn(
        typeof(AbpAutofacWebAssemblyModule),
        typeof(BlazorWebPrerenderingHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyBasicThemeModule),
        typeof(AbpIdentityBlazorModule),
        typeof(AbpTenantManagementBlazorModule)
    )]
    public class BlazorWebPrerenderingBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var environment = context.Services.GetSingletonInstanceOrNull<IWebAssemblyHostEnvironment>();
            var builder = context.Services.GetSingletonInstanceOrNull<WebAssemblyHostBuilder>();

            if (builder != null)
            {
                ConfigureAuthentication(builder);
            }
            if (environment != null)
            {
                ConfigureHttpClient(context, environment);
            }
            ConfigureBlazorise(context);
            ConfigureRouter(context);
            ConfigureUI(builder);
            ConfigureMenu(context);
            ConfigureAutoMapper(context);
        }

        private void ConfigureRouter(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AppAssembly = typeof(BlazorWebPrerenderingBlazorModule).Assembly;
            });
        }

        private void ConfigureMenu(ServiceConfigurationContext context)
        {
            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new BlazorWebPrerenderingMenuContributor(context.Services.GetConfiguration()));
            });
        }

        private void ConfigureBlazorise(ServiceConfigurationContext context)
        {
            context.Services
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();
        }

        private static void ConfigureAuthentication(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("AuthServer", options.ProviderOptions);
                options.UserOptions.RoleClaim = JwtClaimTypes.Role;
                options.ProviderOptions.DefaultScopes.Add("BlazorWebPrerendering");
                options.ProviderOptions.DefaultScopes.Add("role");
                options.ProviderOptions.DefaultScopes.Add("email");
                options.ProviderOptions.DefaultScopes.Add("phone");
            });
        }

        private static void ConfigureUI(WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#ApplicationContainer");
        }

        private static void ConfigureHttpClient(ServiceConfigurationContext context, IWebAssemblyHostEnvironment environment)
        {
            context.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri(environment.BaseAddress)
            });
        }

        private void ConfigureAutoMapper(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BlazorWebPrerenderingBlazorModule>();
            });
        }
    }
}
