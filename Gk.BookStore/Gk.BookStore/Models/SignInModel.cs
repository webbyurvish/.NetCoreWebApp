using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Gk.BookStore.Models
{
    public class SignInModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
