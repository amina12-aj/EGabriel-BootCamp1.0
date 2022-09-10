using Newtonsoft.Json;

namespace RandomUser.WebApp
{
    public class Name
    {
        public string? Title { get; set; }
        [JsonProperty("first")]
        public string? FirstName { get; set; }
        [JsonProperty("last")]
        public string? LastName { get; set; }
    }
}