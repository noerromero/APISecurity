using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISecurity.EFModelsII;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using APISecurity.Services;

namespace APISecurity
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<postgresContext>(options => {
                options.UseNpgsql(@"Server=dev-bd.c4eg064xqfsk.sa-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User ID=sa;Password=Agosto2019$;");
            });
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
                app.UseExceptionHandler();

            app.UseStatusCodePages();
            
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
                //endpoints.MapGet("/", async context =>
                //{
                //    //throw new ApplicationException("Erro de app");
                //    //await context.Response.WriteAsync("Hello World!");
                //    await context.Response.;
                //});
            });
        }
    }
}
