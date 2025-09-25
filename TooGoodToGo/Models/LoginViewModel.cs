using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TooGoodToGo.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}

