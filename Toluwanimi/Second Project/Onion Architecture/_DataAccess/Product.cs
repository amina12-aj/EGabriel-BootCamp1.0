namespace _DataAccess
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } = default!;
        public virtual ProductDetails ProductDetails { get; set; } = default!;
    }
}