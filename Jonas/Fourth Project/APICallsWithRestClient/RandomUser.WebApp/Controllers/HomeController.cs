using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RandomUser.WebApp.Models;
using RestSharp;

namespace RandomUser.WebApp.Controllers;

public class HomeController : Controller
{
    public HomeController() { }

    public async Task<IActionResult> Index()
    {
        List<UserViewModel> model = new();

        var uri = "https://randomuser.me/api/?exc=login,registered,id,location,cell,nat&results=3";
        var client = new RestClient(uri);
        var request = new RestRequest(uri, Method.Get);
        RestResponse response = await client.ExecuteAsync(request);
        var output = JsonConvert.DeserializeObject<ApiResponse>(response.Content!);

        foreach (var user in output!.Results)
        {
            UserViewModel userModel = new()
            {
                Name = user.Name!.FirstName + " " + user.Name.LastName,
                Gender = user.Gender,
                Email = user.Email,
                DOB = user.DOB!.Date,
                Phone = user.Phone,
                Picture = user.Picture!.Large
            };

            model.Add(userModel);
        }
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
