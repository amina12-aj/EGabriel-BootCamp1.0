using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace Fourth_ConsumeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var url = "https://reqres.in/api/users?page=2";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            var Output = response.Content;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            var url = "https://reqres.in/api/users";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "Ajay Kumar",
                job = "Developer"
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync()
        {
            var url = "https://reqres.in/api/users";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "Ajay",
                job = "Developer"
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            var url = "https://reqres.in/api/users?page=2";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Delete);
            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;
            return View();
        }

    }
}