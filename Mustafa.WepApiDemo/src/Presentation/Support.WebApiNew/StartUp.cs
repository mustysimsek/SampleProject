using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Support.Application.Business.Abstracts;
using Support.Application.Business.Concretes;
using Support.Application.Services.Abstracts;
using Support.Application.Services.Concretes;
using Support.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Support.WebApi
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
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //services.AddScoped<IProductDal, EFProductDal>();
            services.AddMvc();
            //services.AddControllers();
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<BevBreadDBContext>(x => x.UseSqlServer(Configuration.GetConnectionString("BevBreadConnection")));

            //services.Configure<RazorViewEngineOptions>(o =>
            //{
            //    o.ViewLocationFormats.Clear();
            //    o.ViewLocationFormats.Add("/Shared/{1}/{0}" + RazorViewEngine.ViewExtension);
            //});
            services.AddScoped<IProductBusiness, ProductBusiness>();
            services.AddScoped<IBranchBusiness, BranchBusiness>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvc(ConfigureRoutes);

            //app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(builder =>
            {
                builder.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        }

        //private void ConfigureRoutes(IRouteBuilder routeBuilder)
        //{
        //    routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index2}/{id?}");
        //    routeBuilder.MapRoute("MyRoute", "Mustafa/{controller=Home}/{action=Index3}/{id?}");
        //}
    }
}

