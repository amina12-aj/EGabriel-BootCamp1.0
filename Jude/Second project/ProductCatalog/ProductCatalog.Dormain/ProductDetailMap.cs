using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductCatalog.Dormain
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetail> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ProductId);
            entityBuilder.Property(p => p.Price);
            entityBuilder.Property(p => p.StockAvailable).IsRequired();
        }
    }
}