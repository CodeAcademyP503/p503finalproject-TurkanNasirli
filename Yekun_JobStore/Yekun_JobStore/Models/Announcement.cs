
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models
{
    public class Announcement
    {
        public Announcement()
        {
            //Educations = new HashSet<Education>();

            //Cities = new HashSet<City>();

            //Experiences = new HashSet<Experience>();

            SocialNetworks = new HashSet<SocialNetwork>();
        }

     
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public DateTime SetTime { get; set; }

        [Required]
        public DateTime AdvertTime { get; set; }

        [Required]
        public DateTime LastTime { get; set; }

        public int ViewCount { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal MaxSalary { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal MinSalary { get; set; }

        public bool UnknownSalary  { get; set; }


        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }

        public Education Education { get; set; }
        public int EducationId { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        //public ICollection<Education> Educations { get; set; }

        //public ICollection<City> Cities { get; set; }

        [Required]
        public string WorkingTime { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public AppUser UserName { get; set; }

        //public ICollection<Experience> Experiences { get; set; }

        [Required]
        public int MinAge { get; set; }

        [Required]
        public int MaxAge { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        public string Demand { get; set; }

        [Required]
        public int SubCategoryId { get; set; }
      
        public SubCategory SubCategory { get; set; }

        public ICollection<SocialNetwork> SocialNetworks { get; set; }

        public string Link { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        public string  Icon { get; set; }

    }

}
