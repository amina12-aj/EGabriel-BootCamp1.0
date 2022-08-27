using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion_Domain;

namespace Onion_Service
{
    public interface IProductDetailService
    {

       ProductDetails GetProductDetail(int id);
    }
}
