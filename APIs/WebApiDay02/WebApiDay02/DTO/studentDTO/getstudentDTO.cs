namespace WebApiDay02.DTO.studentDTO
{
    public class getstudentDTO
    {
        public int studentId { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string addresss { get; set; }
        public int? age { get; set; }
        public int dept_Id { get; set; }

        public int st_Super { get; set; }

        public string deptname { get; set; }
        public string? SupervisorName { get; set; }

    }
}
