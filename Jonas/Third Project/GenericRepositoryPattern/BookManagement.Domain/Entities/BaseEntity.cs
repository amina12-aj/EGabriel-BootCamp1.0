namespace BookManagement.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public string? IPAddress { get; set; }
    }
}