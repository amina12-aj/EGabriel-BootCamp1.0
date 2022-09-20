namespace GR.Data.Entities
{
    public class BaseEntity
    {
        public Int64 Id {get; set;}
        public DateTime DateAdded {get; set;}
        public DateTime ModifiedDate {get; set;}
        public string IPAddress {get; set;}
    }
}