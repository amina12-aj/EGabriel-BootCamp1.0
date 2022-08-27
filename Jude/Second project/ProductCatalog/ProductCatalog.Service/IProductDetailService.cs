using ProductCatalog.Dormain;

namespace ProductCatalog.Service
{
    public interface IProductDetailService
    {
        ProductDetail GetProductDetail(int id);
    }
}