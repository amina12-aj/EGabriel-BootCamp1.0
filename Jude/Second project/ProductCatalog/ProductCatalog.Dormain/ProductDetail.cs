using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Dormain
{
    public class ProductDetail : BaseEntity
    {
        public int StockAvailable { get; set; }  
        public decimal Price { get; set; }  
        public virtual Product? Product{get;set;} 
        public string? ProductName { get; set; }
    }
}