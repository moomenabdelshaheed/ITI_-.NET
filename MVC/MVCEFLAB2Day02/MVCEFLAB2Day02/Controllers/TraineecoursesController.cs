using Microsoft.AspNetCore.Mvc;
using MVCEFLAB2Day02.Models;
using MVCEFLAB2Day02.ViewModel;

namespace MVCEFLAB2Day02.Controllers
{
    public class TraineecoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ITIcontext context = new ITIcontext();
        public IActionResult Result(int tid)
        {
             var traineedetails = context.Trainees.SingleOrDefault(n => n.Id == tid);
            if (traineedetails == null)
                return NotFound();

            var data = context.CrsResult
                .Where(r => r.Trainee_ID == tid)
                .Select(r => new TraineeandCrsResultViewModel
                {
                    CrsName = context.Courses
                                         .Where(t => t.Id == r.crs_ID)
                                         .Select(t => t.Name)
                                         .FirstOrDefault(),
                    TraineeName = traineedetails.Name,
                    Degree = r.Degree,
                    Status = r.Degree >= context.Courses.FirstOrDefault(t => t.Id == r.crs_ID).MinDegree ? "passed" : "failed",
                    Color = r.Degree >= context.Courses.FirstOrDefault(t => t.Id == r.crs_ID).MinDegree ? "success" : "danger"
                })
                .ToList();

            return View("Result", data);

        }
    }
}
