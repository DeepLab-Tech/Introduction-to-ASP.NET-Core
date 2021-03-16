using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace IntroductionAspNetCoreMvc
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                #region Default-1
                endpoints.MapControllerRoute(
                            name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");
                #endregion

                #region MapController Route - 1
                //endpoints.MapControllerRoute(
                //            name: "home",
                //            pattern: "home/Index",
                //            defaults: new { controller = "Home", action = "Index" }
                //        ); 
                #endregion

                #region MapController Route-2
                //endpoints.MapControllerRoute(
                //            name: "Privacy",
                //            pattern: "anasayfa/guvenlik",
                //            defaults: new { controller = "Home", action = "Privacy" }
                //        );

                #endregion

                #region MyController Route-3
                //endpoints.MapControllerRoute(
                //            name: "productlist",
                //            pattern: "urun/list",
                //            defaults: new { controller = "product", action = "list" }
                //        ); 
                #endregion

            });
        }
    }
}
