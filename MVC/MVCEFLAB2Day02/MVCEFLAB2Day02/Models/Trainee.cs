using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFLAB2Day02.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Imag { get; set; }

        public string? Address { get; set; }
        public int Grade {  get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        public List<crsResult> CrsResult { get; set; }
        public virtual Department Department { get; set; }

    }
}
