using lab2.ViewModel;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;
using lab2.Repository;
using NuGet.Protocol.Core.Types;

namespace lab2.Controllers
{
    public class CourseController : Controller
    {
        //private Context _context;

        //public CourseController(Context context)
        //{
        //    _context = context;
        //}
        ICourseRepository courseRepository;
        IDepartmntRepository departmentRepository;
        public CourseController(ICourseRepository courseRepo,IDepartmntRepository departmentRepo)
        {
            courseRepository = courseRepo;
            departmentRepository= departmentRepo;
        }
        public IActionResult Index()
        {
            //List<Course> CrsList = _context.Courses.ToList();
            return View(courseRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Add()
        {
            CourseWithLstOfDeptViewModel crsVM = new CourseWithLstOfDeptViewModel();
            crsVM.Departments = departmentRepository.GetAll();
            return View(crsVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CourseWithLstOfDeptViewModel crsVMRequest)
        {
            if (ModelState.IsValid == true)
            {

                Course course = new Course();
                course.Name = crsVMRequest.Name;
                course.Hours = crsVMRequest.Hours;
                course.MinDegree = crsVMRequest.MinDegree;
                course.Degree = crsVMRequest.Degree;
                course.DepartmentId = crsVMRequest.DepartmentId;

                //_context.Courses.Add(course);
                // _context.SaveChanges();
                courseRepository.Insert(course);
                courseRepository.Save();
                return RedirectToAction("Index");
            }

            crsVMRequest.Departments = departmentRepository.GetAll();
            return View(crsVMRequest);
        }
        //remote validation 
        public IActionResult CheckHours(int Hours)
        {
            if (Hours % 3 == 0) { return Json(true); }
            return Json(false);
        }
    }
}
