using Microsoft.AspNetCore.Mvc;

namespace MVCEFLAB2Day02.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // Test/testmethod?age=200&name=Moomenabdelshaheed?&IsHe[male]=True
        public IActionResult testmethod(int age , string name , Dictionary<string,bool>IsHe) 
        {


        
        return Content("ok");
        }
    }
}
