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
                // services.AddDbContext<ShopDbContext>(options =>
                //     options.UseMySQL(
                //         context.Configuration.GetConnectionString("ShopContextConnection")));

            var serverVersion = new MySqlServerVersion(new Version(10, 4, 21)); // Get the value from SELECT VERSION()
            string connectionString = Configuration.GetConnectionString("server=localhost; username=root;password=123456789;database=punbanhang3;SslMode = none;");
            services.AddDbContext<ShopDbContext>(c => c.UseMySql("server=localhost; username=root;password=123456789;database=punbanhang3;SslMode = none;", serverVersion));

                services.AddDefaultIdentity<ShopUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ShopDbContext>();
            });
        }
    }
}