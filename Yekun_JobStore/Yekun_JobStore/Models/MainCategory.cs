using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models
{
    public class MainCategory
    {
        public MainCategory()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public int Count { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
