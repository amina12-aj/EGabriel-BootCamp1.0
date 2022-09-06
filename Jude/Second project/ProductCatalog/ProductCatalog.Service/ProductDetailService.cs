using ProductCatalog.Dormain;
using ProductCatalog.Repository;

namespace ProductCatalog.Service
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IRepository<ProductDetail> _productDetailRepo;

        public ProductDetailService(IRepository<ProductDetail> productDetailRepo)
        {
            _productDetailRepo = productDetailRepo;
        }
        public ProductDetail GetProductDetail(int id)
        {
            return _productDetailRepo.Get(id);
        }
    }
}