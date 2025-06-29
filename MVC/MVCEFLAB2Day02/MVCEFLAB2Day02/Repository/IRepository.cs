namespace MVCEFLAB2Day02.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        List<T> getbySearch(string se);
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void DeleteById(int id);
        void Save();
    }
}
