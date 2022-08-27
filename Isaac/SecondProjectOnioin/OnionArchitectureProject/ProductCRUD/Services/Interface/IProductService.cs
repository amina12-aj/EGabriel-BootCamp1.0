using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProductService
    {
        IEnumerable<DataAccess.Product> GetProduct();
        DataAccess.Product GetProduct(int id);
    }
}
