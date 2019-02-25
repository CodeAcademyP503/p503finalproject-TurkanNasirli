using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [Required]
        public string Header { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public string Article { get; set; }

        [Required]
        public string Photopath { get; set; }

        [Required]
        public string Content { get; set; }

    }
}
