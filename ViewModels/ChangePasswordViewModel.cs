using System.ComponentModel.DataAnnotations;

namespace HelpDeskWeb.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("Confirm Password", ErrorMessage = "Password does not match.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage="Confirm Password is requied")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmPassword { get; set; }
    }
}
