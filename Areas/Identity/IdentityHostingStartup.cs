using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLightHouse.Areas.Identity.Data;

[assembly: HostingStartup(typeof(NLightHouse.Areas.Identity.IdentityHostingStartup))]
namespace NLightHouse.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NLightHouseIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NLightHouseIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<NLightHouseIdentityDbContext>();
            });
        }
    }
}