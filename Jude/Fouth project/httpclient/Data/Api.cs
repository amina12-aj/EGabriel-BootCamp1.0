using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;

namespace hub.Data
{
    public class Api
    {
        private readonly IHttpClientFactory _httpClient;


        public  Api(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Dictionary<string, object>?> GetHubs(string state)
        {
            try	
            {
                var query = new Dictionary<string, string>()
                {
                    ["state"] = state
                };

                var uri = QueryHelpers.AddQueryString("https://findahub.herokuapp.com/api/getbystate", query!);
                var client = _httpClient.CreateClient();
                var response = await client.GetAsync(uri);
                string responseBody = await response.Content.ReadAsStringAsync();
                var _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data =  JsonSerializer.Deserialize<Dictionary<string, object>>(responseBody, _options);
                return data;
            }
            catch(HttpRequestException e)
            {
               throw e;
                
            }
            
        }
        
    }
}