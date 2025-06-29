using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFLAB2Day02.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Imag { get; set; }
        public decimal? Salary { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }
        [ForeignKey("Course")]

        public int? CourseID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Course? Course { get; set; }
        
    }
}
