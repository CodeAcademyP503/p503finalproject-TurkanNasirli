using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models
{
    public class SubCategory
    {
        public SubCategory()
        {
            Announcements = new HashSet<Announcement>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int MainCategoryId { get; set; }

        public MainCategory MainCategory { get; set; }

        public ICollection<Announcement> Announcements { get; set; }
    }
}