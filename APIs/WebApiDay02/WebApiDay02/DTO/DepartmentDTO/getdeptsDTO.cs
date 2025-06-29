using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDay02.DTO.DepartmentDTO
{
    public class getdeptsDTO :AdddeptDTO
    {
        public int Dept_Id { get; set; }
        public int Students_count { get; set; }

      

    }
}
