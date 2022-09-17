using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace searchApp.Domain
{
    public class ScholarResponse
    {
        public List<object> results { get; set; }
        public List<object> image_results { get; set; }
        public object total { get; set; }
        public List<object> answers { get; set; }
        public string html { get; set; }
        public double ts { get; set; }
        public string device_region { get; set; }
        public string device_type { get; set; }
    }


}