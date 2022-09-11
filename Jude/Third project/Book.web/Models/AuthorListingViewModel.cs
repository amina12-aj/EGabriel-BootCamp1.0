using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.web.Models
{
    public class AuthorListingViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int TotalBooks { get; set; }
    }
}