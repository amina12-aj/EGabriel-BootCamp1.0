using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
   public class BlogModel:BaseEntity
    {
       
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        
    }
}
