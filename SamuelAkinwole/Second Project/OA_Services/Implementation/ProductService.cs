using OA_DataAccess;
using OA_Repository;
using OA_Services.Interface;

namespace OA_Services.Implementation
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