using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hub.Models;
using hub.Data;
using System.Text.Json;

namespace hub.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository _repo;

    public HomeController(ILogger<HomeController> logger, IRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index([FromForm] string state){
        var result = _repo.GetHubs(state);
        if(result.ContainsKey("success") == true)
        {
            var res = result["success"].ToString();
            var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<HubModel>?  hubs =  JsonSerializer.Deserialize<List<HubModel>>(res!, _options);
            ViewBag.Result = hubs;
            return View();
        }
        else
        {
            ViewBag.Error = result["error"].ToString();
            return View();
        }
        
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
