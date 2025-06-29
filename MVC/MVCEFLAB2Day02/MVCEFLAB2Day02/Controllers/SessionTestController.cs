using Microsoft.AspNetCore.Mvc;

namespace MVCEFLAB2Day02.Controllers
{
    public class SessionTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetSession(string name , int age)
        {
            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("age",age);
            return Content($"The Name and the age has been saved");

        }
        public IActionResult GetSession() { 
        string name = HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("age");
            return Content($"The Name is {name} and the age is {age}");
}
    }
}
