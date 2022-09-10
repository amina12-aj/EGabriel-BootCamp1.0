namespace GenericRepo.Data.Interface
{
    public class AttendanceRepository
    {
        private readonly IGenericRepository<Attendance> repository;

        public AttendanceRepository(IGenericRepository<Attendance> repository)
        {
            this.repository = repository;
        }

        public int CreateAttendance(Attendance model)
        {
            return repository.Create(model);
        }
        
        public Attendance GetById(int id)
        {
            return repository.GetById(id);
        }
        
        public IQueryable<Attendance> GetAll()
        {
            return repository.GetAll();
        }
    }
}