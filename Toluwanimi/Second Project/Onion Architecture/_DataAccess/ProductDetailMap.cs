using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _DataAccess
{
    public class ProductDetailMap : BaseEntity
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ProductId);
            entityBuilder.Property(p => p.StockAvailable).IsRequired();
            entityBuilder.Property(p => p.Price);
        }
    }
}