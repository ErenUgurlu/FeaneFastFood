using System;
using FeaneFastFood.Areas.Identity.Data;
using FeaneFastFood.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FeaneFastFood.Areas.Identity.IdentityHostingStartup))]
namespace FeaneFastFood.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FeaneFastFoodContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FeaneFastFoodContextConnection")));

                services.AddDefaultIdentity<FeaneFastFoodUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<FeaneFastFoodContext>();
            });
        }
    }
}