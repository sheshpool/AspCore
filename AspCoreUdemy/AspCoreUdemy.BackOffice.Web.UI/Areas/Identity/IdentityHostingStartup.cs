using System;
using AspCoreUdemy.BackOffice.Web.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AspCoreUdemy.BackOffice.Web.UI.Areas.Identity.IdentityHostingStartup))]
namespace AspCoreUdemy.BackOffice.Web.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AspCoreUdemyBackOfficeWebUIDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AspCoreUdemyBackOfficeWebUIDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AspCoreUdemyBackOfficeWebUIDbContext>();
            });
        }
    }
}