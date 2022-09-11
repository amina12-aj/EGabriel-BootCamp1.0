using API_Consume.Model;
using API_Consume.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace API_Consume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpotifyAccount _spotify;
        private readonly IConfiguration _configuration;
        private readonly ISpotifyService _spotifyService;

        public HomeController(
            ISpotifyAccount spotifyAccountService,
            IConfiguration configuration,
        ISpotifyService spotifyService
       )
        {
            _spotify = spotifyAccountService;
            _configuration = configuration;
            _spotifyService = spotifyService;
        }



        public async Task<IActionResult> Index()
        {
            var newReleases = await GetReleases();

            return View(newReleases);
        }

        private async Task<IEnumerable<Release>> GetReleases()
        {
            try
            {
                var token = await _spotify.GetToken(
                    _configuration["Spotify:ClientId"],
                    _configuration["Spotify:ClientSecret"]);

                var newReleases = await _spotifyService.GetNewReleases("US", 20, token);

                return newReleases;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);

                return Enumerable.Empty<Release>();
            }
        }

         }
    }
  
    