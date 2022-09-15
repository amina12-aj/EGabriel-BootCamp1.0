namespace _DataAccess
{
    public class ProductDetails : BaseEntity
    {
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
        public virtual Product Product { get; set; } = default!;
    }
}