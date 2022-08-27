
using ProductCatalog.Dormain;
using ProductCatalog.Repository;

namespace ProductCatalog.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepo;

        public ProductService(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }
        public IEnumerable<Product> GetProduct()
        {
            return _productRepo.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productRepo.Get(id);
        }
    }
}