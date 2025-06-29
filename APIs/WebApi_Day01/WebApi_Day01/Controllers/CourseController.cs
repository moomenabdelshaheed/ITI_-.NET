using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Day01.Model;

namespace WebApi_Day01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public ITIcontext Context;

        public CourseController(ITIcontext context)
        {
            Context = context;
        }
        [HttpGet]
        public List<Course> Get()
        {
            return Context.Courses.ToList();
        }
        [HttpGet("ByName/{name}")]
        public ActionResult CouseByName(string name)
        {
            Course course = Context.Courses.FirstOrDefault(c => c.Crs_name == name);
            if (course == null) return NotFound();
            return Ok(course);
        }

        [HttpDelete("{id:int}")]
        public ActionResult deleteCourse(int id) { 
        
        Course c = Context.Courses.SingleOrDefault(c => c.Id == id);
            if (c == null) return NotFound();
            Context.Courses.Remove(c);
            Context.SaveChanges();
            return Ok(c);
        
        
        }
        [HttpPut("{id:int}")]
        public ActionResult put(int id, Course course) {
            if (id != course.Id) return BadRequest();
            Course c = Context.Courses.Find(id);
            if (c == null) return NotFound();
            c.Crs_name = course.Crs_name;
            c.Crs_desc = course.Crs_desc;
            Context.SaveChanges();
            return NoContent();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            if (course == null)
                return BadRequest("Course parameter is null");
            if (!ModelState.IsValid)
                return BadRequest(ModelState); 

            Context.Courses.Add(course);
            Context.SaveChanges();
            return CreatedAtAction("getbyid", new { id = course.Id }, course);
        }
        [HttpGet("{id:int}")]
        public ActionResult getbyid(int id)
        {
            //Course c = Context.Courses.Where(c => c.Id == id).FirstOrDefault();
            Course c = Context.Courses.Find(id);
            if (c == null) return NotFound();
            else return Ok(c);

        }
    }
}
