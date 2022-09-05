namespace GenericRepo.Models
{
    public class Blog:BaseEntity
    {
     
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
