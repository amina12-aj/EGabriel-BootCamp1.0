using HttpClientTest.Models;
using Newtonsoft.Json;

namespace HttpClientTest.Services
{
    public class DataService : IDataService
    {
        private HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public DataService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient= httpClient;
            _configuration = configuration;
        }

        public async Task<TimezoneResponse> GetTimezone()
        {
            //Api Key
            var RapidApiKey = _configuration["ApiFootballKeys:Apikey"];
            var RapidApiHost = _configuration["ApiFootballKeys:ApiHost"];
            //Api Uri
            string apiUri = _configuration["ApiFootballKeys:ApiUrl"];

            //Headers
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", RapidApiKey);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", RapidApiHost);
            // _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", apiKey);
            //Send Request
            var response = await _httpClient.GetAsync(apiUri);

            if (response.IsSuccessStatusCode) 
            {
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TimezoneResponse>(result);
            }
            else 
            {
                return null;
            }
        }

        public async Task<PredictionsModel> GetPredictions()
        {
            //Api Key
            var RapidApiKey = _configuration["ApiFootballKeys:Apikey"];
            var RapidApiHost = _configuration["ApiFootballKeys:ApiHost"];
            //Api Uri
            string apiUri = _configuration["ApiFootballKeys:PredictionsUrl"];

            //Headers
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", RapidApiKey);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", RapidApiHost);
            // _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", apiKey);
            //Send Request
            var response = await _httpClient.GetFromJsonAsync<PredictionsModel>(apiUri);
            
            return response;
        }
    }
}