using System.ComponentModel.DataAnnotations;

namespace LoginAndLogout.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool Present { get; set; }

    }
}
