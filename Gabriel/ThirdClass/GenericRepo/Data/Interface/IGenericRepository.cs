namespace GenericRepo
{
    public interface IGenericRepository<T> where T : class, new()
    {
        int Create(T entity, bool isSave = true);

        T GetById(int id);

        int SaveChangesToDb();
        
        IQueryable<T> GetAll();
    }
}