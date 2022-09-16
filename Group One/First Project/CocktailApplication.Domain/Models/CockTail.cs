using Newtonsoft.Json;

namespace CocktailApplication.Presentation.Models
{
    public class CockTail
    {

          [JsonProperty("drinks")]
        public Dictionary<string, string>[] Drinks { get; set; } = default;
        
    }
}
