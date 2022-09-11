using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HttpClientTest.Models;
using HttpClientTest.Services;

namespace HttpClientTest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDataService _service;

    public HomeController(ILogger<HomeController> logger, IDataService service)
    {
        _logger = logger;
        _service = service;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var result = await _service.GetTimezone();
        var result2 = await _service.GetPredictions();
        return View(result);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
