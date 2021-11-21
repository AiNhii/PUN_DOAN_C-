using System;
using System.Configuration;
using comestic_csharp.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(comestic_csharp.Areas.Identity.IdentityHostingStartup))]
namespace comestic_csharp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public IConfiguration Configuration { get; }
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 21)); // Get the value from SELECT VERSION()
            string connectionString = Configuration.GetConnectionString("server=localhost; username=root;password=01672362745Ngan;database=comestic;SslMode = none;");
            services.AddDbContext<ShopDbContext>(c => c.UseMySql("server=localhost; username=root;password=01672362745Ngan;database=comestic;SslMode = none;", serverVersion));

                services.AddDefaultIdentity<ShopUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ShopDbContext>();
            });
        }
    }
}