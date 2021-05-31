using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SpotifyTracks.Controllers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpotifyTracks.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private string token = "";

    
        // GET: api/values
        [HttpGet]
        public async Task<Root> GetRecentlyPlayed()
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.GetAsync("https://api.spotify.com/v1/me/player/recently-played?limit=25");
                response.EnsureSuccessStatusCode();
                string apiResponse = await response.Content.ReadAsStringAsync();
                var recentlyPlayed = JsonConvert.DeserializeObject<Root>(apiResponse);
                return recentlyPlayed;
            }
        }
    }
}

