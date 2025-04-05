using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;
namespace lab2.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        //[Unique]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [Range(50, 100)]  
        public int Degree { get; set; }
        [Required]
        [UnderDegree]
        public int MinDegree { get; set; }
        //[Remote("CheckHours", "Course")]
        public int Hours { get; set; }
        //foreign key
        public int DepartmentId { get; set; }
        // Navigation Property
        public Department Department { get; set; }  
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<CrsResult> CrsResults { get; set; }
    }
}
