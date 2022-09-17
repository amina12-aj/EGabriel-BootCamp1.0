using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace searchApp.Domain
{
    public class Entry
    {
        public string title { get; set; }
        public TitleDetail title_detail { get; set; }
        public List<Link> links { get; set; }
        public string link { get; set; }
        public string id { get; set; }
        public bool guidislink { get; set; }
        public string published { get; set; }
        public List<int> published_parsed { get; set; }
        public string summary { get; set; }
        public SummaryDetail summary_detail { get; set; }
        public Source source { get; set; }
        public List<SubArticle> sub_articles { get; set; }
    }

    public class Feed
    {
        public GeneratorDetail generator_detail { get; set; }
        public string generator { get; set; }
        public string title { get; set; }
        public TitleDetail title_detail { get; set; }
        public List<Link> links { get; set; }
        public string link { get; set; }
        public string language { get; set; }
        public string publisher { get; set; }
        public PublisherDetail publisher_detail { get; set; }
        public string rights { get; set; }
        public RightsDetail rights_detail { get; set; }
        public string updated { get; set; }
        public List<int> updated_parsed { get; set; }
        public string subtitle { get; set; }
        public SubtitleDetail subtitle_detail { get; set; }
    }

    public class GeneratorDetail
    {
        public string name { get; set; }
    }

    public class PublisherDetail
    {
        public string email { get; set; }
    }

    public class RightsDetail
    {
        public string type { get; set; }
        public object language { get; set; }
        public string @base { get; set; }
        public string value { get; set; }
    }

    public class NewsResponse
    {
        public Feed feed { get; set; }
        public List<Entry> entries { get; set; }
        public double ts { get; set; }
        public string device_region { get; set; }
        public string device_type { get; set; }
    }

    public class Source
    {
        public string href { get; set; }
        public string title { get; set; }
    }

    public class SubArticle
    {
        public string url { get; set; }
        public string title { get; set; }
        public string publisher { get; set; }
    }

    public class SubtitleDetail
    {
        public string type { get; set; }
        public object language { get; set; }
        public string @base { get; set; }
        public string value { get; set; }
    }

    public class SummaryDetail
    {
        public string type { get; set; }
        public object language { get; set; }
        public string @base { get; set; }
        public string value { get; set; }
    }

    public class TitleDetail
    {
        public string type { get; set; }
        public object language { get; set; }
        public string @base { get; set; }
        public string value { get; set; }
    }


}