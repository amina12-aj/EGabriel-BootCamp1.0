using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace restsharpclient.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task < string > Index() {
    var url = "https://reqres.in/api/users?page=2";
    var client = new RestClient(url);
    var request = new RestRequest(url, Method.Get);
    RestResponse response = await client.ExecuteAsync(request);
    var Output = response.Content;
    return Output!;
}
}
