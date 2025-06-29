using Microsoft.AspNetCore.Mvc;
using MVCEFLAB2Day02.Models;
using MVCEFLAB2Day02.ViewModel;

namespace MVCEFLAB2Day02.Controllers
{
    public class TraineeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ITIcontext context  = new ITIcontext();
        
        public IActionResult Result(int tid,int cid) {

            var trianeedetails = context.Trainees.FirstOrDefault(n => n.Id == tid);
            var coursedetails = context.Courses.Where(n=>n.Id==cid).SingleOrDefault();
          var  courseresult = context.CrsResult.Where(g=>g.Trainee_ID==tid && g.crs_ID==cid).SingleOrDefault();
        TraineeandCrsResultViewModel tcv = new TraineeandCrsResultViewModel();
            tcv.TraineeName = trianeedetails.Name;
            tcv.CrsName = coursedetails.Name;
            tcv.Degree = courseresult.Degree;
            if (tcv.Degree > coursedetails.MinDegree)
            {
                tcv.Color = "green";
                tcv.Status = "passed";
            }
            else if((tcv.Degree < coursedetails.MinDegree))
            {
                tcv.Color = "red";
                tcv.Status = "failed";
            }
            return View("Result", tcv);
            
          
        }
       
    }
}
