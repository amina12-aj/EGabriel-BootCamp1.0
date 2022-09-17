using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace searchApp.Domain
{
    public class Image
    {
        public string src { get; set; }
        public string alt { get; set; }
    }

    public class ImageResult
    {
        public Image image { get; set; }
        public Link link { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string title { get; set; }
        public string domain { get; set; }
    }

    public class ImageResponse
    {
        public List<object> results { get; set; }
        public List<ImageResult> image_results { get; set; }
        public object total { get; set; }
        public List<object> answers { get; set; }
        public double ts { get; set; }
        public string device_region { get; set; }
        public string device_type { get; set; }
    }


}