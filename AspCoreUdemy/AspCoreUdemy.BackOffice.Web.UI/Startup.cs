using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreUdemy.Core.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AspCoreUdemy.Core.Data.Models;
using Microsoft.AspNetCore.Identity;
using AspCoreUdemy.Core.Data.Infrastructure;
using AspCoreUdemy.Core.Data.Service.Run;

namespace AspCoreUdemy.BackOffice.Web.UI
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
            services.AddRazorPages();

            string connectionString = this.Configuration.GetConnectionString("DefaultContext");
            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);
            services.AddTransient<IApplicationRoleRepository, ApplicationRoleRepository>();
            services.AddTransient<IApplicationUserRepository, ApplicationUserRepository>();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "paragrapheEdit",
                    pattern: "edition-paragraphe/{id}",
                    defaults: new { controller = "Paragraphe", action = "Edit" },
                    constraints: new {id = @"\d+"}
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
