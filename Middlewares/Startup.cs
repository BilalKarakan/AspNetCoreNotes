using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Middlewares.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middlewares
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMiddleware<ResponseEditingMiddleware>();
            app.UseMiddleware<RequestEditingMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute
                //(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=index}/{id?}"
                //);
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
