using CRUDWithMongoDB.Models;

namespace CRUDWithMongoDB.Services
{
    public interface IProductRepository
    {
        Task Create(Product product);

        Task<IEnumerable<Product>> GetAll();

        Task<Product> Get(string id);

        Task<Product> Update(string id, Product product);

        Task<bool> Delete(string id);
    }
}