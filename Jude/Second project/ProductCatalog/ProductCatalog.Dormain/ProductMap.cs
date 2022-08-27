using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductCatalog.Dormain
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> enttiyBuilder)
        {
            enttiyBuilder.HasKey(p => p.ProductId);
            enttiyBuilder.HasOne(p => p.ProductDetail).WithOne(p => p.Product).HasForeignKey<ProductDetail>(x => x.ProductId);
        }
    }
} 