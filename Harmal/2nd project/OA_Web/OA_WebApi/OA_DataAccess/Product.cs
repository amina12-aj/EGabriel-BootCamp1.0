using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_DataAccess
{
    public class Product : BaseEntity
    {
        public String ProductName { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
