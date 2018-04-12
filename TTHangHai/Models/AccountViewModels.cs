using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TTHangHai.Models
{

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
