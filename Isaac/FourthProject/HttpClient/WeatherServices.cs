namespace ExternalApi
{
    public class WeatherServices : IWeatherServices
    {
        private HttpClient _httpClient;

        public WeatherServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public  async Task<string> Get(string cityName)
        {
            //var httpClient = _httpClientFactory.CreateClient("weather");

            var apiKey = "6d83513529694803bc8184148220909";

            string ApiUrl =  $"?key={apiKey}&q={cityName}";

            var response = await _httpClient.GetAsync(ApiUrl);
            return await response.Content.ReadAsStringAsync();

        }
    }
}
