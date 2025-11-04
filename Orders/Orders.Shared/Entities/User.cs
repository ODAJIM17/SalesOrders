using Microsoft.AspNetCore.Identity;
using Orders.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "{0} can not exceed {1} characters.")]
        [Required(ErrorMessage = "{0} es is required.")]
        public string Document { get; set; } = null!;

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "{0} can not exceed {1} characters.")]
        [Required(ErrorMessage = "{0} es is required.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "{0} can not exceed {1} characters.")]
        [Required(ErrorMessage = "{0} es is required.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "{0} can not exceed {1} characters.")]
        [Required(ErrorMessage = "{0} es is required.")]
        public string Address { get; set; } = null!;

        [Display(Name = "Photo")]
        public string? Photo { get; set; }

        [Display(Name = "User Type")]
        public UserType UserType { get; set; }

        public City? City { get; set; }

        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a {0}.")]
        public int CityId { get; set; }

        [Display(Name = "User")]
        public string FullName => $"{FirstName} {LastName}";
    }
}