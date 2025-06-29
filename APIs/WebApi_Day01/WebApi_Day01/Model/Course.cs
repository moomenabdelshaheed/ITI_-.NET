using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Day01.Model
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Crs_name { get; set; }
        [MaxLength(150)]

        public string? Crs_desc { get; set; }

        public int? Duration { get; set; }
    }
}
