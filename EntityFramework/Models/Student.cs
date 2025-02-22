using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    // this class create columns in table
    public class Student
    {
        [Key] // this ensure that while database is created than Id id primary key.
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }  
    }
}
