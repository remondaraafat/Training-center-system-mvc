using lab2.Models;
using lab2.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class InstructorController : Controller
    {
        private  Context _context;

        public InstructorController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Instructor> Inslist = _context.Instructors.ToList();
            return View(Inslist);
        }
        public IActionResult Details(int id)
        {
            Instructor instructor = _context.Instructors.FirstOrDefault(i => i.Id == id);

            return View(instructor);
        }
        [HttpGet]
        public IActionResult Add()
        {

            InstructorWithDeptCrsListVM insVM=new InstructorWithDeptCrsListVM();
            insVM.courses=_context.Courses.ToList();
            insVM.departments = _context.Departments.ToList();
            return View(insVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(InstructorWithDeptCrsListVM insVM)
        {
            if (insVM.Name == null)
            {
                insVM.courses = _context.Courses.ToList();
                insVM.departments = _context.Departments.ToList();
                return View(insVM);
            }
            Instructor instructor=new Instructor();
            instructor.Name= insVM.Name;
            instructor.Address= insVM.Address;
            instructor.CrsId= insVM.CrsId;
            instructor.Salary= insVM.Salary;
            instructor.DeptId= insVM.DeptId;
            //image
            instructor.Image = insVM.Image="";

            _context.Instructors.Add(instructor);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        //ajacx call
        public JsonResult GetDeptCrsList(int DeptId) {
            var courses=_context.Courses.Where(c=>c.DepartmentId==DeptId).Select(c => new { Id = c.Id.ToString(), Name = c.Name}).ToList();
            return Json(courses);
        }
       
    }
}
