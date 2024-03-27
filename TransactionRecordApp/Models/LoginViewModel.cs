using System.ComponentModel.DataAnnotations;

namespace TransactionRecordApp.Models
{
    public class LoginViewModel
    {
        //used snippet 5 to set up the login of a user 
        //complete with username password return url and remember me variables
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string? Password { get; set; }

        public string? ReturnUrl { get; set; }

        public bool RememberMe { get; set; }


    }
}
