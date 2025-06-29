using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace MVCEFLAB2Day02.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "Course name must be at most 25 characters.")]
        [Unique]
        public string Name { get; set; }

        [Range(50, 100, ErrorMessage = "Course Degree must be between 50 and 100.")]
        public int Degree { get; set; }

        [Remote(action: "CheckMinDegree", controller: "Courses", AdditionalFields = "Degree", ErrorMessage = "Minimum degree must be less than or equal to the course degree.")]
        public int MinDegree { get; set; }

        [Remote(action: "CheckHours", controller: "Courses", ErrorMessage = "Hours of Course MUST be divided by 3.")]
        public int Hours { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        public Department? Department { get; set; }
        public List<Instructor> Instructors { get; } = new();
        public List<crsResult> CrsResult { get; } = new();
    }
}
