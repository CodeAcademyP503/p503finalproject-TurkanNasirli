using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models.ViewModels
{
    public class RegisterModel_s 
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Şifrə düzgün yazılmayıb")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int SocialNetworkID { get; set; }

        public SocialNetwork SocialNetwork { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Şifrələr uyğunlaşmır")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public static implicit operator AppUser(RegisterModel_s registerModel_S)
        {
            return new AppUser
            {
                Email = registerModel_S.Email,
                UserName = registerModel_S.Name
            };
        }
    }
}
