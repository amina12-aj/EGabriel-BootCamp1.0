using OA_DataAccess;
using OA_Repository;
using OA_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Services.Implementation
{
    public class ProductsDetailsService : IProductsDetailsService
    {
        private IRepository<ProductDetails> productDetailsRepository;
        public ProductsDetailsService(IRepository<ProductDetails> productDetailsRepository)
        {
            this.productDetailsRepository = productDetailsRepository;
        }

        public ProductDetails GetProductDetail(int id)
        {
            return productDetailsRepository.Get(id);
        }
    }
}
