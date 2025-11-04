using Orders.Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.DTOs
{
    public class UserDTO : User
    {
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} can not exceed {1} characters.")]
        public string Password { get; set; } = null!;

        [Compare("Password", ErrorMessage = "Password and confirm password do not match.")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} allows between  {2} y {1} characteres.\")].")]
        public string PasswordConfirm { get; set; } = null!;
    }
}