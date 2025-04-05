using lab2.Models;
using lab2.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class TraineeController : Controller
    {
        private Context _context;

        public TraineeController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index(int TId,int CrsId)
        {
            TraineeResultViewModel traineeResult = new TraineeResultViewModel();
            Trainee trainee = _context.Trainees.FirstOrDefault(x => x.Id == TId);
            Course course=_context.Courses.FirstOrDefault(x=>x.Id==CrsId);
            CrsResult crsResult=_context.CrsResults.FirstOrDefault(x=>x.CrsId==CrsId && x.TraineeId==TId);
            traineeResult.TraineeName = trainee.Name;
            traineeResult.CourseName = course.Name;
            traineeResult.Passed=crsResult.Degree>course.MinDegree?true:false;
            ViewBag.Color = traineeResult.Passed ? "green" : "red";

            return View(traineeResult);
        }
    }
}
