using CocktailApplication.Domain;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CocktailApplication.Service
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public ApiService(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<IEnumerable<Drink>?> Filter(string category)
        {
            var XRapidAPIKey = _config["X-RapidAPI-Key"];
            var XRapidAPIHost = _config["X-RapidAPI-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://the-cocktail-db.p.rapidapi.com/filter.php?c={category}"),
                Headers =
                {
                    { "X-RapidAPI-Key", XRapidAPIKey },
                    { "X-RapidAPI-Host", XRapidAPIHost },
                },
            };

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse>(result)!.Drinks;
            }

            return null;
        }

        public async Task<IEnumerable<Drink>?> GetAllIngredients()
        {
            var XRapidAPIKey = _config["X-RapidAPI-Key"];
            var XRapidAPIHost = _config["X-RapidAPI-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://the-cocktail-db.p.rapidapi.com/list.php?i=list"),
                Headers =
                {
                    { "X-RapidAPI-Key", XRapidAPIKey },
                    { "X-RapidAPI-Host", XRapidAPIHost },
                },
            };

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse>(result)!.Drinks;
            }

            return null;
        }

        public async Task<Drink?> Lookup()
        {
            var XRapidAPIKey = _config["X-RapidAPI-Key"];
            var XRapidAPIHost = _config["X-RapidAPI-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://the-cocktail-db.p.rapidapi.com/random.php"),
                Headers =
                {
                    { "X-RapidAPI-Key", XRapidAPIKey },
                    { "X-RapidAPI-Host", XRapidAPIHost },
                },
            };

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse>(result)!.Drinks.FirstOrDefault();
            }

            return null;
        }

        public async Task<IEnumerable<Drink>?> Search(string name)
        {
            var XRapidAPIKey = _config["X-RapidAPI-Key"];
            var XRapidAPIHost = _config["X-RapidAPI-Host"];

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://the-cocktail-db.p.rapidapi.com/search.php?s={name}"),
                Headers =
                {
                    { "X-RapidAPI-Key", XRapidAPIKey },
                    { "X-RapidAPI-Host", XRapidAPIHost },
                },
            };

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse>(result)!.Drinks;
            }

            return null;
        }
    }
}