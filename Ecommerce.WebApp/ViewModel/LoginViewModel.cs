using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.WebApp.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
