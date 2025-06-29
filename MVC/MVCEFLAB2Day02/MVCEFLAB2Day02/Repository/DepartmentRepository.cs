using MVCEFLAB2Day02.Models;

namespace MVCEFLAB2Day02.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ITIcontext context;
        public DepartmentRepository()
        {
            context = new ITIcontext();
        }
        public void Add(Department obj)
        {
            context.Departments.Add(obj);
        }

        public void DeleteById(int id)
        {
            Department dept=GetById(id);
            context.Departments.Remove(dept);
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }



        public Department GetById(int id)
        {
          return  context.Departments.SingleOrDefault(d=>d.Id == id);
        }

        public List<Department> getbySearch(string se)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department obj)
        {
            Department dept= new Department();
            dept.Id = obj.Id;
            dept.Name = obj.Name;
            dept.Courses = obj.Courses;
            dept.Trainees = obj.Trainees;
            dept.Manager = obj.Manager;
            dept.Instructors = obj.Instructors;
            
        }
    }
}
