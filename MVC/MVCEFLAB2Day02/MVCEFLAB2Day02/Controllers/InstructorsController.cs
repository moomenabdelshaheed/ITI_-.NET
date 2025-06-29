using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCEFLAB2Day02.Models;
using MVCEFLAB2Day02.ViewModel;

namespace MVCEFLAB2Day02.Controllers
{
    public class InstructorsController : Controller
    {
        ITIcontext context = new ITIcontext();
        public IActionResult Index()
        {
            //Instructors/Index

            List<Instructor> instructors = context.Instructors.Include(x => x.Department).Include(y => y.Course).ToList();
            if (instructors != null && instructors.Count != 0)
            {
                return View(instructors);
            }
            else
            {
                return NotFound();
            }

        }
        public IActionResult details(int id)
        {
            Instructor instructor = context.Instructors
                .Include(x => x.Department)
                .Include(x => x.Course)
                .FirstOrDefault(x => x.Id == id);

            if (instructor == null)
            {
                return NotFound(); // أو return RedirectToAction("Index");
            }

            return View("details", instructor);
        }
        public IActionResult New() {
            //List<Instructor> instructors = context.Instructors.Include(x => x.Department).Include(y => y.Course).ToList();
            //List<Department> depts = context.Departments.Include(x=>x.Courses)
            //List<Course> crs = context.Courses.Include(c => c.Department).ToList();
            InstructordeptcourseViewModel viewModel = new InstructordeptcourseViewModel
            {
                instructor = new Instructor(),
                courses = context.Courses.ToList(),
                departments = context.Departments.ToList()
            };

            return View("New", viewModel);

        }
        //public IActionResult Create(Instructor ins)
        //{
        //    if (ins.Name != null && ins.Imag != null && ins.Course != null && ins.Salary != null) {
        //        context.Instructors.Add(ins);
        //        //context.Courses.Add(cr);
        //        context.SaveChanges();
        //        return RedirectToAction("Index", "Instructors");
        //    }
        //    return View("New");
        //}
        [HttpPost]

        [HttpPost]
        public IActionResult Create(Instructor ins, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileName(imageFile.FileName);
                var path = Path.Combine("wwwroot/images", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                // احفظ اسم الصورة في خاصية Imag
                ins.Imag = fileName;
            }

            context.Instructors.Add(ins);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        //public IActionResult Create(Instructor ins)
        //{
        //    //if (ins.Imag != null && ins.Imag.Length > 0)
        //    //{
        //    //    var filename = Path.GetFileName(ins.Imag);
        //    //    var path = Path.Combine("wwwroot/Images",filename);

        //        context.Instructors.Add(ins);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    //}
        //    //return Content("New");

        //    // لو الـ ModelState مش صالح، رجع نفس الصفحة مع الـ ViewModel اللي فيه بيانات الاختيارات
        //    //var vm = new InstructordeptcourseViewModel
        //    //{
        //    //    instructor = ins,
        //    //    courses = context.Courses.ToList(),
        //    //    departments = context.Departments.ToList()
        //    //};

        //    //return View("New", vm);
        //}






    }
}
