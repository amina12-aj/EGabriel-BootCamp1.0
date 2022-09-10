namespace GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        protected DataBaseContext _db;

        public GenericRepository(DataBaseContext db)
        {
            _db = db;
        }

        public int Create(T entity, bool isSave = true)
        {
            if (entity == null)
            {
                return 3;
            }

            _db.Set<T>().Add(entity);

            if (isSave)
            {
                return SaveChangesToDb();
            }

            return 1;
        }

        public T GetById(int id)
        {
            var entity = _db.Set<T>().Find(id);

            return entity;
        }

        public int SaveChangesToDb()
        {
            int saveResult;

            try
            {
                int tempResult = _db.SaveChanges();
                saveResult = 1;
            }
            catch (Exception ex)
            {
                saveResult = -1;
                throw;
            }
            return saveResult;
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }
    }
}