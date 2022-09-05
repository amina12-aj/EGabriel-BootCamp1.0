using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_DataAccess
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } = default!;
        public virtual ProductDetails ProductDetails { get; set; } = default!;
    }
}
