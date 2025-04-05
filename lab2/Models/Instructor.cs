using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        // Foreign Key
        public int DeptId { get; set; }
        public int CrsId { get; set; }

        // Navigation Properties
        [ForeignKey("DeptId")]
        public Department Department { get; set; }

        [ForeignKey("CrsId")]
        public Course Course { get; set; }
    }
}
