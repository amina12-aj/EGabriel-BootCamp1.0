using DataAccess;
using Repository;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class ProductDetailsService : IProductDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetProductDetail(int id)
        {
            return productDetailsRepository.Get(id);
        }
    }
}
