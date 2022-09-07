using GR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Repository.ProductRepository
{
    public interface IProductRepo
    {
        List<Product> GetAllProducts();
        Task<Product> GetProduct(int Id);
        Task<int> CreateProduct(Product product);
        Task<int> Deleteproduct(int Id);
        Task<int> UpdateProduct(int Id);
    }
}
