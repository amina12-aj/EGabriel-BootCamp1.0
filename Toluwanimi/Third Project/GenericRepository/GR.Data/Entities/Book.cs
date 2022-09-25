namespace GR.Data.Entities
{
    public class Book : BaseEntity
    {
        public Int64 AuthorId{get; set;}
        public string Name {get; set;}
        public string Category {get; set;}
        public string ISBN{get; set;}
        public string Publisher {get; set;}
        public virtual Author Author {get; set;}
    }
}