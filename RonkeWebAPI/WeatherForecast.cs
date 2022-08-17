<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/WeatherForecast.cs
namespace ProductsCRUDAPI
========
using System;

namespace RonkeWebAPI
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:RonkeWebAPI/WeatherForecast.cs
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

<<<<<<<< HEAD:OkpalaOlisaemeka/ProductsCRUDAPI/WeatherForecast.cs
        public string? Summary { get; set; }
    }
}
========
        public string Summary { get; set; }
    }
}
>>>>>>>> 42d07f28588ba7797d8b3f15d3000dfdf941f211:RonkeWebAPI/WeatherForecast.cs
