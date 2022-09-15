using _DataAccess;

namespace _Service
{
    public interface IProductService
    {
        IEnumerable<_DataAccess.Product> GetAllProduct();
        _DataAccess.Product GetProduct(int id);
    }
}