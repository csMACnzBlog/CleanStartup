using CleanStartup.StartupExtensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanStartup
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) => services
            .AddCustomisedCookies()
            .AddCustomisedMvc();

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) => app
            .UseCustomisedErrorHandling(env)
            .UseHttpsRedirection()
            .UseStaticFiles()
            .UseCustomisedMvc();
    }
}
