using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEFLAB2Day02.Models;
using MVCEFLAB2Day02.Repository;
using NuGet.Protocol.Core.Types;

namespace MVCEFLAB2Day02.Controllers
{
    public class CoursesController : Controller
    {
        //private readonly ITIcontext context = new();
        ICourseRepository courseRepository;
        IDepartmentRepository departmentRepository;
        public CoursesController(ICourseRepository courseRepository, IDepartmentRepository departmentRepository)
        {
           
            this.courseRepository = courseRepository;// new CourseRepository();
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Index(string searchText)
        {
            var courses = courseRepository.GetAll();

            if (!string.IsNullOrEmpty(searchText))
            {
                courses = courseRepository.getbySearch(searchText);
            }
            return View("Index", courses);
        }
        public IActionResult Result(int id)
        {
            var course = courseRepository.GetById(id);
            return View("Result");
        }

        public IActionResult New()
        {
            ViewData["depts"] = departmentRepository.GetAll();  
            return View("New", new Course());
        }

        [HttpPost]
        public IActionResult SaveNew(Course course)
        {
            ViewData["depts"] = departmentRepository.GetAll();

            if (ModelState.IsValid)
            {
                courseRepository.Add(course);
                courseRepository.Save();
                return RedirectToAction("Index");
            }

            return View("New", course);
        }

        public IActionResult CheckMinDegree(int MinDegree, int Degree)
        {
            if (MinDegree > Degree)
            {
                return Json("Minimum degree must be less than or equal to the course degree.");
            }
            return Json(true);
        }

        public IActionResult CheckHours(int hours)
        {
            if (hours % 3 != 0)
            {
                return Json("Hours of Course MUST be divided by 3.");
            }
            return Json(true);
        }
    }
}
