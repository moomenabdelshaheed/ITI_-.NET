using Microsoft.AspNetCore.Mvc;
using MVCLAB1.Models;

namespace MVCLAB1.Controllers
{
    public class StudentController : Controller
    {
        StudentBL StudentBL = new StudentBL();
        public IActionResult all()
        {
            List<Student> studentslist = StudentBL.getStudents();
            return View("showall", studentslist);
        }
        public IActionResult getone(int id)
        {
            Student onestudent = StudentBL.getbyid(id);
            return View("getone", onestudent);

        }
    }
}
