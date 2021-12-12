using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using comestic_csharp.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using comestic_csharp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace comestic_csharp
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
            services.ConfigureApplicationCookie (options => {
                // options.Cookie.HttpOnly = true;  
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);  
                options.LoginPath = $"/login/";                                 // Url đến trang đăng nhập
                options.LogoutPath = $"/logout/";   
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";   // Trang khi User bị cấm truy cập
            });

            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                // Trên 5 giây truy cập lại sẽ nạp lại thông tin User (Role)
                // SecurityStamp trong bảng User đổi -> nạp lại thông tinn Security
                options.ValidationInterval = TimeSpan.FromSeconds(5); 
            });
                        
            services.AddMvc();

            services.AddRazorPages();

            // services.AddDistributedMemoryCache();
            // services.AddSession(options =>
            // {
            //     options.IdleTimeout = new TimeSpan(0,30, 0);
            //     // options.Cookie.HttpOnly = true;
            //     // options.Cookie.IsEssential = true;
            //     options.Cookie = new CookieBuilder()
            //      {
            //          IsEssential = true,
            //          SameSite = SameSiteMode.Lax,
            //          SecurePolicy = CookieSecurePolicy.SameAsRequest,
            //          Name = "comestic_csharp"
            //      };
            // });

            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(cfg => {                    // Đăng ký dịch vụ Session
                    cfg.Cookie.Name = "PUN";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                    cfg.IdleTimeout = new TimeSpan(0,30, 0);    // Thời gian tồn tại của Session
            });

            services.AddControllersWithViews();

            var serverVersion = new MySqlServerVersion(new Version(10, 4, 21)); // Get the value from SELECT VERSION()
            string connectionString = Configuration.GetConnectionString("server=localhost; username=root;password=01672362745Ngan;database=comestic_test4;SslMode = none;");
            services.AddDbContext<ShopDbContext>(c => c.UseMySql("server=localhost; username=root;password=01672362745Ngan;database=comestic_pun;SslMode = none;", serverVersion));
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
            

            app.UseSession();

            app.UseCookiePolicy();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
