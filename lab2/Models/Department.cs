using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        // Navigation Properties
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Trainee> Trainees { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
