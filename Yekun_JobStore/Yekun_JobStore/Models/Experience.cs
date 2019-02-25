using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yekun_JobStore.Models
{
    public class Experience
    {
        public Experience()
        {
            JobSeekers= new HashSet<JobSeeker>();
            Announcements = new HashSet<Announcement>();

        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<JobSeeker> JobSeekers { get; set; }

        public ICollection<Announcement> Announcements { get; set; }

    }
}