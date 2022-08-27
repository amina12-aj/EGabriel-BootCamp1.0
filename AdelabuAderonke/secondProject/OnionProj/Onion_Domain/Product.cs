using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Domain
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public virtual ProductDetails ProductDetails { get; set; }
    }
}
