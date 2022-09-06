using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Services
{
    public interface IProductDetailsService
    {
        OA_DataAccess.ProductDetails GetProductDetail(int id);
    }
}
