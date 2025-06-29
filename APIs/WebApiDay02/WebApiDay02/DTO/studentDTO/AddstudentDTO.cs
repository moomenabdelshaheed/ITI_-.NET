using System.ComponentModel.DataAnnotations;

namespace WebApiDay02.DTO.studentDTO
{
    public class AddstudentDTO
    {
        public string St_Fname { get; set; }

        
        public string St_Lname { get; set; }

        
        public string St_Address { get; set; }

        public int? St_Age { get; set; }

        public int? Dept_Id { get; set; }

        public int? St_super { get; set; }
    }
}
