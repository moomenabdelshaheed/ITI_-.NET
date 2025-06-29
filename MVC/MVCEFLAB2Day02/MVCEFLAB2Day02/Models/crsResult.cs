using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFLAB2Day02.Models
{
    public class crsResult
    {

        public int ID { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Course")]
        public int? crs_ID { get; set; }
        [ForeignKey("Trainee")]
        public int Trainee_ID { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
