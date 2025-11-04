using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "{0} is required.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(6, ErrorMessage = "{0} requires minimun {1} characters.")]
        public string Password { get; set; } = null!;
    }
}