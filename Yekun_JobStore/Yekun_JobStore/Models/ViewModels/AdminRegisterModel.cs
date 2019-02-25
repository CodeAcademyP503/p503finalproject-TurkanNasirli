using System.ComponentModel.DataAnnotations;

namespace Yekun_JobStore.Models.ViewModels
{
    public class AdminRegisterModel
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

        [Required(ErrorMessage = "Şifrə düzgün yazılmayıb")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Şifrələr uyğunlaşmır")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public static implicit operator AppUser(AdminRegisterModel adminRegisterModel)
        {
            return new AppUser
            {
                Email = adminRegisterModel.Email,
                UserName = adminRegisterModel.Name
            };
        }
    }
}
