using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Dormain
{
    public class Product : BaseEntity
    {
        public string? ProductName { get; set; }
        public virtual ProductDetail? ProductDetail { get; set; }
    }
}