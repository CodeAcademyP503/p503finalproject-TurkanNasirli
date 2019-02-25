using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Yekun_JobStore.Models;

namespace Yekun_JobStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost webHost = CreateWebHostBuilder(args).Build();

            using (IServiceScope serviceScope = webHost.Services.CreateScope())
            {
                using (JobstoreDbContext jobstoreDbContext = serviceScope.ServiceProvider.GetRequiredService<JobstoreDbContext>())
                {
                    var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    DefaultDb.Seed(jobstoreDbContext, roleManager);
                }
            }
            webHost.Run();

        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var startup = typeof(Startup).GetTypeInfo().Assembly.FullName;
            return new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseWebRoot(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"))
            .ConfigureAppConfiguration(x =>
            {

                x.AddJsonFile(path: "appsettings.json", optional: true);
            })
            .UseStartup(startup)
            .UseDefaultServiceProvider(x =>
            {
                x.ValidateScopes = true;
            });
           
        }
      
    }
}
