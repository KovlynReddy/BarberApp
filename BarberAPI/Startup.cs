using BarberAPI.Data.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberAPI
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

            services.AddMvcCore();
            services.AddControllers();
            services.AddHttpClient();
            services.AddRouting();

            services.AddDbContext<BarberContext>(opt=>opt.UseSqlServer
            (Configuration.GetConnectionString("BarberConnection"))
            );



            //services.AddScoped<IBarber,BarberRepo>;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseHttpMethodOverride();
            app.UseRouting();
                
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllers();

                //endpoints.MapControllerRoute(
                //    name : "BarberApi",
                //    pattern: "api/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
