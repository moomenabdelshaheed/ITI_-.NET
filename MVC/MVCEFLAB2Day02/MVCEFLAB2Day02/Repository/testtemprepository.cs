using MVCEFLAB2Day02.Models;

namespace MVCEFLAB2Day02.Repository
{
    public class testtemprepository : ICourseRepository
    {
        public void Add(Course obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return new List<Course>() {
          new Course() { Id = 22,Name = "sadsd", Degree = 33, MinDegree = 12,Hours=33, DepartmentID = 24,  },
          new Course() { Id = 22, Degree = 33, MinDegree = 12, DepartmentID = 24,Hours=44, Name = "sadsd" } } ;
        }
            

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> getbySearch(string se)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
