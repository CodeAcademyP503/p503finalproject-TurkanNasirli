using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yekun_JobStore.Models;

namespace Yekun_JobStore
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
               services.ConfigureApplicationCookie(x =>
               {
                   x.Cookie.Expiration = TimeSpan.FromHours(2);
                   x.AccessDeniedPath = "/Account/AccessDenied";
                   //x.LoginPath = "/Account/Login";
                   x.LogoutPath = "/Account/Logout";

               });



               services.AddDistributedMemoryCache();

               services.AddSession(options =>
               {
                   //options.Cookie.Expiration =TimeSpan.FromHours(2);
                   options.Cookie.HttpOnly = false;
                   options.Cookie.IsEssential = true;
               });    

            //scoped services
            services.AddDbContext<JobstoreDbContext>(x => {
                x.UseSqlServer(Configuration["Database:JobStoreDb"]);
            });    
          
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnm";
                options.User.RequireUniqueEmail = false;


 
            })
                                       .AddEntityFrameworkStores<JobstoreDbContext>()
                                         .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseSession();
            app.UseAuthentication();


            app.UseMvc(routes =>
            {

                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=AdminHome}/{action=AdminIndex}/{id?}"
                );
      

                routes.MapRoute(
                  name: null,
                  template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
   
}
