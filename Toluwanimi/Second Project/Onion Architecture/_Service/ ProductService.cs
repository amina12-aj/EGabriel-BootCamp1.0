using _DataAccess;
using _Repository;

namespace _Service
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;
        private IRepository<ProductDetails> productDetailsRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<ProductDetails> productDetailsRepository)
        {
            this.productRepository = productRepository;
            this.productDetailsRepository = productDetailsRepository;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
           return productRepository.Get(id);
        }

        
    }
}