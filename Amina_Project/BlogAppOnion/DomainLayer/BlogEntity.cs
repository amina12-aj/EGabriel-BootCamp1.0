using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
   public class BlogEntity: BaseEntity
    { 
        public string?  Title  { get; set; }
        public string? Description { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
