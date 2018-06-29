using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace CleanStartup.StartupExtensions
{
    public static class ErrorHandlingExtensions
    {
        // Some Extensions won't have both Services and Middleware.

        public static IApplicationBuilder UseCustomisedErrorHandling(this IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            return app;
        }
    }
}
