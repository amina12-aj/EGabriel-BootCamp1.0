using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace RestSharpAPI.Controllers
{
    public class ResharpTestController : Controller
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
        public async Task<IActionResult> IndexPostAsync()
        {
            var url = "https://reqres.in/api/users";
            var  client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "Akinwole Samuel",
                job = "Software developer"
            };

            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);

            var output = response.Content;

            return View();
        }

        [HttpPut]
        public async Task<IActionResult> IndexPutAsync()
        {
            var url = "https://reqres.in/api/users";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "Akinwole",
                job = "Software developer"
            };

            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);

            var output = response.Content;

            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> IndexDeleteAsync()
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
