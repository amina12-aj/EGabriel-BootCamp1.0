using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace searchApp.Domain
{
    public class Serp
    {
        public string query { get; set; }
        public string website { get; set; }
        public int searched_results { get; set; }
        public int position { get; set; }
    }
}