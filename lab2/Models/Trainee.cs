using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public decimal Grade { get; set; }

        // Foreign Key
        public int DeptId { get; set; }

        // Navigation Property
        [ForeignKey("DeptId")]
        public Department Department { get; set; }

        public ICollection<CrsResult> CrsResults { get; set; }
    }
}
