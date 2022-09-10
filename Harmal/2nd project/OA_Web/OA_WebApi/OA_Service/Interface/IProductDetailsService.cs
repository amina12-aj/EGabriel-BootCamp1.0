using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service.Interface
{
    public interface IProductDetailsService
    {

        OA_DataAccess.ProductDetails GetProductDetail(int id);
    }
}
