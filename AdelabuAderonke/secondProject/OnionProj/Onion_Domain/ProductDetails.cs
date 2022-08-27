using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Domain
{
    public class ProductDetails:BaseEntity
    {
        public int StockAvailable { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public string ProductName { get; set; }
    }
}
