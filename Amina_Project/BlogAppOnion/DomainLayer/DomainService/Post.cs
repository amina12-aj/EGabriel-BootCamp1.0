using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainService
{
    public class Post:BaseEntity
    {
        public string? Title { get; set; } = "";
        public string? Description { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
