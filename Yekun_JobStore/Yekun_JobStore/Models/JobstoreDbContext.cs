using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yekun_JobStore.Models.ViewModels;
namespace Yekun_JobStore.Models
{
    public class JobstoreDbContext:IdentityDbContext<AppUser,IdentityRole,string>
    {
     

        public JobstoreDbContext(DbContextOptions<JobstoreDbContext> dbContextOptions):base(dbContextOptions){ }

        public DbSet<MainCategory> MainCategories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<JobSeeker> JobSeekers { get; set; }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<SocialNetwork> Socials { get; set; }

        public DbSet<City> Cities { get; set; }

    }
}
