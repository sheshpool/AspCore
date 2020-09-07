using System;
using AspCoreUdemy.Core.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AspCoreUdemy.Core.Data.Models;

[assembly: HostingStartup(typeof(AspCoreUdemy.BackOffice.Web.UI.Areas.Identity.IdentityHostingStartup))]
namespace AspCoreUdemy.BackOffice.Web.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DefaultContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultContext")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    }
                )
                //.AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<DefaultContext>();

                //services.AddDefaultIdentity<ApplicationUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<DefaultContext>();
                //services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DefaultContext>();
            });
        }
    }
}