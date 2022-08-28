using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Services
{
    public interface IProductService
    {
        IEnumerable<OA_DataAccess.Product> GetProduct();
        OA_DataAccess.Product GetProduct(int id);
    }
}
