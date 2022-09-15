using _DataAccess;

namespace _Service
{
   public interface IProductDetailsService
    {
        _DataAccess.ProductDetails GetProductDetail(int id);
    }
}