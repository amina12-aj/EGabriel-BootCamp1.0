using System.Net.Http;
using System.Threading.Tasks;

namespace MakingHttpRequests
{
    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }

    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Get(string cityName)
        {
            var apiKey = "5034abeda1b04c4aacc53820220609";

            string APIURL = $"?key={apiKey}&q={cityName}&aqi=no";
            var response = await _httpClient.GetAsync(APIURL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
