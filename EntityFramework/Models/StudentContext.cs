
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    // this class help us to set the data in table that is created from student class
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } // DBSet is responsible for setting the data of student in database.
        // upper Students ke pass sari rows ayegi jo student class me defined hai
    }
}
