using Onion_Domain;
using Onion_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Service
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IRepository<ProductDetails> _productDetailsRepository;

        public ProductDetailService(IRepository<ProductDetails> productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }
        public ProductDetails GetProductDetail(int id)
        {
            return _productDetailsRepository.Get(id);
        }
    }
}
