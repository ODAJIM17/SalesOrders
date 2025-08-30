using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category")]
        [MaxLength(50, ErrorMessage = "{0} can not exceed {1} characters.")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Name { get; set; } = null!;
    }
}