using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Services.Interface
{
    public interface IProductsDetailsService
    {
        ProductDetails GetProductDetail(int id);
    }
}
