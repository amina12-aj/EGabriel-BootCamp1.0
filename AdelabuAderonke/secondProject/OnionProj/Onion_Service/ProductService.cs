using Onion_Domain;
using Onion_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Service
{
    public class ProductService:IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<ProductDetails> _productDetailRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductDetails> productDetailRepository)
        {
            _productRepository = productRepository;
            _productDetailRepository = productDetailRepository;
        }
        public IEnumerable<Product> GetProduct()
        {
            return _productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productRepository.Get(id);
        }
    }
}

