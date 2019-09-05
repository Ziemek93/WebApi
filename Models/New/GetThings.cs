using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public partial class LoginTo
    {


        [Required(ErrorMessage = "Proszę wprowadzić LOGIN.")]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić HASŁO.")]

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }

    }
}
