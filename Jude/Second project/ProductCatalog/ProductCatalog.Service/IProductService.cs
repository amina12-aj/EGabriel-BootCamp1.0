using ProductCatalog.Dormain;

namespace ProductCatalog.Service
{
    public interface IProductService
    {
        
        IEnumerable<Product> GetProduct();  
        Product GetProduct(int id);
    }
}