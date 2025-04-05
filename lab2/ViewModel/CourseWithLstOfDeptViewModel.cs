using lab2.Models;
using lab2.Controllers;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace lab2.ViewModel
{
    public class CourseWithLstOfDeptViewModel
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
        [Remote("CheckHours", "Course")]
        public int Hours { get; set; }
        //foreign key
        public int DepartmentId { get; set; }
        // listof departement 
        public List<Department>? Departments { get; set; }
    }
}
