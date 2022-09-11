using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Quotes.WebApp.Models;

namespace Quotes.WebApp.Controllers;

public class HomeController : Controller
{
    public HomeController() { }

    public async Task<IActionResult> Index()
    {
        List<QuoteViewModel> model;

        var uri = "https://programming-quotes-api.herokuapp.com/Quotes?count=5";

        HttpClient client = new();

        var responseBody = await client.GetStringAsync(uri);

        model = JsonConvert.DeserializeObject<List<QuoteViewModel>>(responseBody)!;

        return View(model);
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
