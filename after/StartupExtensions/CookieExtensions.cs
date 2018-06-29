using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CleanStartup.StartupExtensions
{
    public static class CookieExtensions
    {
        public static IServiceCollection AddCustomisedCookies(this IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            return services;
        }

        public static IApplicationBuilder UseCustomisedCookies(this IApplicationBuilder app)
        {
            // For symmetry, you may wish to still put this in an extension,
            // but you could also decide not to.
            app.UseCookiePolicy();

            return app;
        }
    }
}
