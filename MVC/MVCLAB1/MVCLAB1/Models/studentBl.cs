namespace MVCLAB1.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();

            students = new() {// new هنا بتمثل ال list 
            new(){Id = 1,Name="moomen",Address="asdsadsaadsa",ImageUrl="man.png"},// new هنا بتمثل الطالب 
            new(){Id = 2,Name="samy",Address="alex",ImageUrl="man.png"},
            new(){Id = 3,Name="galal",Address="cairo",ImageUrl="man.png"},
            new(){Id = 4,Name="mostafa",Address="egypt",ImageUrl="man.png"},
            new(){Id = 5,Name="hassan",Address="tanta",ImageUrl="man.png"},

            };// ممكن اعملها كدة 
            students.Add(new Student {Id= 1 ,Name = "moomen" ,Address="tahway",ImageUrl= "man.png"});// او ممكن كدة 
        }
        public List<Student> getStudents() {
        
        return students;
        
        }
        public Student getbyid(int id) {
        return students.FirstOrDefault(x=>x.Id == id);
        }
    }
}
