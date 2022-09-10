using Microsoft.AspNetCore.Mvc;

namespace ExternalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
     
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherServices _weatherServices;
        private static HttpClient _httpClient;


        static WeatherForecastController()
        {
            _httpClient = new HttpClient();
        }
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                        IWeatherServices weatherServices)
        {
            _logger = logger;
            _weatherServices = weatherServices;
            
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
          return await _weatherServices.Get(cityName);
            
        }
    }
}