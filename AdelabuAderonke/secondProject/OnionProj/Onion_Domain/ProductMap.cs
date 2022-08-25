using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Domain
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ProductId);
            entityBuilder.HasOne(p => p.ProductDetails).WithOne(p => p.Product).HasForeignKey<ProductDetails>(x => x.ProductId);

        }
    }
}
