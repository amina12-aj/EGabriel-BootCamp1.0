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
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductDetails> productDetailRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductDetails> productDetailRepository)
        {
            this.productRepository = productRepository;
            this.productDetailRepository = productDetailRepository;
        }
        public IEnumerable<Product> GetProduct()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }
    }
   
}
