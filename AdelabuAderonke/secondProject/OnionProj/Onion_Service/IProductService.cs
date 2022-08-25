using Onion_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProduct();
        Product GetProduct(int id);
    }
}
