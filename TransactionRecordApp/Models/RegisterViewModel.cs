using System.ComponentModel.DataAnnotations;

namespace TransactionRecordApp.Models
{
    public class RegisterViewModel
    {
        //used snippet 6 to set up the regestring of a user 
        //complete with username password and a confirm password
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}
