namespace searchApp.Domain
{
    public class AdditionalLink
    {
        public string text { get; set; }
        public string href { get; set; }
    }

    public class Cite
    {
        public string domain { get; set; }
        public string span { get; set; }
    }

    public class Result
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public List<AdditionalLink> additional_links { get; set; }
        public Cite cite { get; set; }
    }

    public class SearchResponse
    {
        public List<Result> results { get; set; }
        public List<object> image_results { get; set; }
        public int total { get; set; }
        public List<string> answers { get; set; }
        public double ts { get; set; }
        public string device_region { get; set; }
        public string device_type { get; set; }
    }
}