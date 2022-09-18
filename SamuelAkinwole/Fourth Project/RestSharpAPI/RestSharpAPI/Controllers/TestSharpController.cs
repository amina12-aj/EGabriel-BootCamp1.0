using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace RestSharpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSharpController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var url = "https://localhost:44351/User";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            var Output = response.Content;

            return Ok(Output);
        }

        [HttpPost]
        public async Task<IActionResult> IndexPostAsync()
        {
            var url = "https://localhost:44351/User";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
               FirstName = "Samuel",
               LastName = "Akinwole",
               Location = "Canada",
               PhoneNumber = 7748992829292,
               Email = "sam@gmail.com"
            };

            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);

            var output = response.Content;

            return Ok(output);
        }

        [HttpPut]
        public async Task<IActionResult> IndexPutAsync()
        {
            var url = "https://localhost:44351/User";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                FirstName = "Samuel",
                LastName = "Akinwole",
                Location = "Canada",
                PhoneNumber = 7748992829292,
                Email = "samuel@gmail.com"
            };

            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = await client.ExecuteAsync(request);

            var output = response.Content;

            return Ok(output);
        }

        [HttpDelete]
        public async Task<IActionResult> IndexDeleteAsync()
        {
            var url = "https://localhost:44351/User";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Delete);
            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;

            return NoContent();
        }
    }
}
