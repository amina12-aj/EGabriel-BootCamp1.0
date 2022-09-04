using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Data.Entities
{
    public class Address : BaseEntity
    {
        public long CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
