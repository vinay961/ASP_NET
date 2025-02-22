using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class EmployeeModel
    {

        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public string? Email { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
