namespace GenericRepo.Data
{
    public class TodoItemRepository
    {
        private readonly IGenericRepository<TodoItem> repository;

        public TodoItemRepository(IGenericRepository<TodoItem> repository)
        {
            this.repository = repository;
        }

        // int Create(T entity, bool isSave = true);
        public int CreateTodoItem(TodoItem model)
        {
            return repository.Create(model);
        }
        // T GetById(int id);
        public TodoItem GetById(int id)
        {
            return repository.GetById(id);
        }
        // int SaveChangesToDb();
        // IQueryable<T> GetAll();
        
        public IQueryable<TodoItem> GetAll()
        {
            return repository.GetAll();
        }
    }
}