using MVCEFLAB2Day02.Models;

namespace MVCEFLAB2Day02.ViewModel
{
    public class InstructordeptcourseViewModel
    {
        public Instructor instructor {  get; set; } 
        public List<Course> courses { get; set;} = new List<Course>();
        public List<Department> departments { get; set; } = new List<Department>();
    }
}
