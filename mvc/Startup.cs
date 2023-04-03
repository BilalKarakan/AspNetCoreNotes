using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace mvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules"))
            });

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                    name: "routeOfBilal",
                    pattern: "Bilal/{action}",
                    defaults: new { Controller = "Home" }
                );

                endpoint.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller}/{Action}/{id?}",
                    defaults: new {Controller = "Home", Action = "Index"}
                );
            }
            
            );
        }
    }
}
