using CocktailApplication.Presentation.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailApplication.Repository
{
    public class Consume:  IConsume
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public Consume(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration; 
        }

        public async Task<CockTail> GetIngredients()
        {
            var RapidAPIKey = _configuration["ApiKey"];
            var RapidAPIHost = _configuration["ApiHost"];
            
            var RequestUri = "https://the-cocktail-db.p.rapidapi.com/search.php?s=vodka";


            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", RapidAPIKey);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", RapidAPIHost);

            var request = await _httpClient.GetAsync(RequestUri);
          if (request.IsSuccessStatusCode)  
            {
               
                var response = await request.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CockTail>(response);   
            }
          else
            {
                return null;
            }
        }
        

    }
}
