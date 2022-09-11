using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class book:BaseEntity
    {
        
            public Int64 AuthorId { get; set; }

            public string Name { get; set; }

            public string ISBN { get; set; }

            public string Publisher { get; set; }

            public virtual Author Author { get; set; }

      
    }
}
