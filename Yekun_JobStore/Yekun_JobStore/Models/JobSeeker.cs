using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models
{
    public class JobSeeker
    {
        public JobSeeker()
        {
            SocialNetworks = new HashSet<SocialNetwork>();
            //Cities = new HashSet<City>();
            //Experiences = new HashSet<Experience>();
            //Educations = new HashSet<Education>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string JobName { get; set; }

        public ICollection<SocialNetwork> SocialNetworks { get; set; }

        public string Link { get; set; }

        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

        [Column(TypeName ="decimal(8,2)")]
        public decimal Salary { get; set; }

        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }

        public Education Education { get; set; }
        public int EducationId { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        //public ICollection<City> Cities { get; set; }

        //public ICollection<Experience>  Experiences { get; set; }

        //public ICollection<Education>  Educations { get; set; }

        public string WorkTime { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public AppUser Email { get; set; }

        public string Phone { get; set; }

        public string Knowledge { get; set; }

        public DateTime SetTime { get; set; }

        public string About { get; set; }

        [Required]
        public int ViewCount { get; set; }
      
        public string PhotoPath { get; set; }


    }
}
