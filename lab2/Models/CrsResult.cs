using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class CrsResult
    {
        [Key]
        public int Id { get; set; }
        public decimal Degree { get; set; }

        // Foreign Keys
        public int CrsId { get; set; }
        public int TraineeId { get; set; }

        // Navigation Properties
        [ForeignKey("CrsId")]
        public Course Course { get; set; }

        [ForeignKey("TraineeId")]
        public Trainee Trainee { get; set; }
    }
}
