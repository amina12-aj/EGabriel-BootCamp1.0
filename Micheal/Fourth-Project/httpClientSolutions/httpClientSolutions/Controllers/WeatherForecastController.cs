using Microsoft.AspNetCore.Mvc;

namespace httpClientSolutions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            this.weatherService = weatherService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get(string cityName)
        {
return await weatherService.Get(cityName);     
        }
    }
}