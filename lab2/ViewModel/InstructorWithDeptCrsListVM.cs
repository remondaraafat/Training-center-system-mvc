using lab2.Models;

namespace lab2.ViewModel
{
    public class InstructorWithDeptCrsListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        // Foreign Key
        public int DeptId { get; set; }
        public int CrsId { get; set; }
        //dept list
        public List<Department> departments { get; set; }
        //crs list
        public List<Course> courses { get; set; }
    }
}
