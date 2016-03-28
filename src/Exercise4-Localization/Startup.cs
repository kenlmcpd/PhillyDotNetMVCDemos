using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

using System.Globalization;
using Microsoft.AspNet.Localization;

namespace Demo5_Localization
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Replace this:
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            // Add Code Here

            app.UseMvcWithDefaultRoute();
            app.UseIISPlatformHandler();
        }

        // Entry point for the application.
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()                
                .UseServer("Microsoft.AspNetCore.Server.Kestrel")
                .UseStartup<Startup>()                
                .Build();

            host.Start();
        }
    }
}
