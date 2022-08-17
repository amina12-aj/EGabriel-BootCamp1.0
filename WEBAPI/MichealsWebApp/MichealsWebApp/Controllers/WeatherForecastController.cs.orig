<<<<<<< HEAD
<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/Controllers/WeatherForecastController.cs
using Microsoft.AspNetCore.Mvc;

namespace ProductsCRUDAPI.Controllers
========
=======
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MichealsWebApp.Controllers
<<<<<<< HEAD
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:WEBAPI/MichealsWebApp/MichealsWebApp/Controllers/WeatherForecastController.cs
=======
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
<<<<<<< HEAD
<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/Controllers/WeatherForecastController.cs
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
========
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:WEBAPI/MichealsWebApp/MichealsWebApp/Controllers/WeatherForecastController.cs
=======
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

<<<<<<< HEAD
<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/Controllers/WeatherForecastController.cs
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
========
=======
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
<<<<<<< HEAD
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:WEBAPI/MichealsWebApp/MichealsWebApp/Controllers/WeatherForecastController.cs
=======
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211
            })
            .ToArray();
        }
    }
<<<<<<< HEAD
<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/Controllers/WeatherForecastController.cs
}
========
}
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:WEBAPI/MichealsWebApp/MichealsWebApp/Controllers/WeatherForecastController.cs
=======
}
>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211
