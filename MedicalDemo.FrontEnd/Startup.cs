using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalDemo.Business;
using MedicalDemo.Business.Interfaces;
using MedicalDemo.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MedicalDemo.FrontEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //Agregamos la dependencia de base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseMySQL(Configuration.GetConnectionString("ApplicationDb"))
          );

            //Hacemos el map de las dependencias de repositorios
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //Hacemos el map de las dependencias de Servicios
            services.AddScoped(typeof(Business.IExpedienteMedicoService), typeof(Business.ExpedienteMedicoService));

            //Activamos el versionador de los controles
            services.AddApiVersioning();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
