using Microsoft.EntityFrameworkCore;
using MVCEFLAB2Day02.Models;

namespace MVCEFLAB2Day02.Repository
{
    public class CourseRepository : ICourseRepository
    {
        ITIcontext context;
        public CourseRepository(ITIcontext _context)

        {
            this.context = _context;
            //context = new ITIcontext();
        }
        public void Add(Course obj)
        {
            context.Courses.Add(obj);
        }

        public void DeleteById(int id)
        {
            Course crs = GetById(id);
            context.Courses.Remove(crs);
            //context.Courses.Remove(GetById(id));
        }

        public List<Course> GetAll()
        {
           return context.Courses.Include(c=>c.Department).ToList();
        }
        public List<Course> getbySearch(string s)
        {
            return context.Courses.Include(c => c.Department).Where(c=>c.Name.Contains(s)).ToList();
        }
        public Course GetById(int id)
        {
           return context.Courses.SingleOrDefault(x=>x.Id==id);
        }

        public void Save()
        {
           context.SaveChanges();
        }

        public void Update(Course obj)
        {
            Course orgcourse = GetById(obj.Id);// هنا انا جبت البروجكت اللى عاوز اعدل فيه
        
           
            orgcourse.Name = obj.Name; //يعنى الكورس اللى جاى فوق فى الميثود هحط الداتا بتاعتة فى الاورجينال كورس
            orgcourse.Degree = obj.Degree;
            orgcourse.Hours = obj.Hours;
            orgcourse.MinDegree = obj.MinDegree;
            orgcourse.DepartmentID = obj.DepartmentID;
            
        }
    }
}
