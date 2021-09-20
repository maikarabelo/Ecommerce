using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodBite.Data;
using FoodBite.Models;
using FoodBite.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FoodBite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FoodbiteContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("FoodBiteContextDb")));
             services.AddScoped<IFoodRepository, FoodRepository>();
             services.AddTransient<IMailService, NullMailService>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();
             services.AddControllersWithViews();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           /* if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }*/

           app.UseHttpsRedirection();
           // app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index" });
            });
        }
    }
}

