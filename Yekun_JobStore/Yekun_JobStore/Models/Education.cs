using System.ComponentModel.DataAnnotations;

namespace Yekun_JobStore.Models
{
    public class Education
    {
   
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}