using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CocktailApplication.Presentation.Models;
using CocktailApplication.Repository;
using System.Collections.Concurrent;

namespace CocktailApplication.Presentation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConsume _ingredient;


    public HomeController(ILogger<HomeController> logger, IConsume ingredient)
    {
        _logger = logger;
        _ingredient = ingredient;
    }

    public async Task<IActionResult> GetAsync()
    {
        var result =  _ingredient.GetIngredients();
        await result;
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
