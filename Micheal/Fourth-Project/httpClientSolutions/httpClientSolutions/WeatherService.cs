namespace httpClientSolutions
{

    public interface IWeatherService
    {
        Task<string> Get(string cityName);
    }
    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> Get(string cityName)
        {
            var apiKey = "cbe576fd9fb54e5eb71161303220909";
            string APIURL = $"?Key={apiKey}&q={cityName}";
            var response  = await _httpClient.GetAsync(APIURL); 
            return await response.Content.ReadAsStringAsync();  
        }
    }
}
