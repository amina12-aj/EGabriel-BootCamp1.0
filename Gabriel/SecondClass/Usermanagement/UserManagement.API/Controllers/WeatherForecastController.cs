using Microsoft.AspNetCore.Mvc;
using UserManagement.Domain.DTOs;
using UserManagement.Domain.Entities;
using UserManagement.Repository.UserRepo;

namespace UserManagement.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IUserRepository _repo;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateUserDto model)
    {
        if (model == null) return BadRequest("Invalid");

        User user = new()
        {
            Name = model.Name,
            DateOfBirth = model.DateOfBirth,
            Email = model.Email
        };

        await _repo.Createuser(user);

        return Ok(user);
    }
}
