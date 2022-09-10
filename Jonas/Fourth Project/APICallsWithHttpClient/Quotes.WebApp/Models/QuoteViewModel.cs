using Newtonsoft.Json;

namespace Quotes.WebApp.Models
{
    public class QuoteViewModel
    {
        public string? Id { get; set; }
        public string? Author { get; set; }
        [JsonProperty("en")]
        public string? Quote { get; set; }
    }
}