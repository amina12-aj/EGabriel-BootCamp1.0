using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace searchApp.Domain
{
    public class VideoResponse
    {
        public List<Result> results { get; set; }
        public List<object> image_results { get; set; }
        public int total { get; set; }
        public List<object> answers { get; set; }
        public double ts { get; set; }
        public string device_region { get; set; }
        public string device_type { get; set; }
    }


}