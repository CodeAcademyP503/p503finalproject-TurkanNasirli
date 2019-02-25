using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Models.ViewModels
{
    public class RegisterModel_a
    {


        [Required]
        [Display(Name="User name")]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Şifrələr uyğunlaşmır")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public static implicit operator AppUser(RegisterModel_a registerModel_A)
        {
            return new AppUser
            {

                 Email = registerModel_A.Email,
                UserName = registerModel_A.Name,

            };
        }
    }
}
