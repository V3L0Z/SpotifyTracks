using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotifyTracks.Controllers.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpotifyTracks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private string token = "BQBk-KcRRcSZx03RujTjgOcHE5-9aNym-jFhyx5uHLvnVsL0d5giTsPKwBhospq0nc-LtCBlW0V88vt-1VZmvYWlN73tpcODsld_yqfZaqPOieakVGzSA05zX_yrX9-C2-OfB9X6oLXT0Pb-bUxRlY0tTa0luh49Cvua7ccjyB4bhAFvL-nIsP1pcvQWfC2ksKwIlbrJvd_hpI7uc29xHGBzNc7NRndgeUj6o_nQbSJj5hTtqrrpGulBW9qsFWVP-JMHOOI_USNcH6tkGQ";

        [HttpGet]
        public async Task<Genre> GetAllGenres()
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await client.GetAsync("https://api.spotify.com/v1/recommendations/available-genre-seeds");
                response.EnsureSuccessStatusCode();
                string apiResponse = await response.Content.ReadAsStringAsync();
                var genreList = JsonConvert.DeserializeObject<Genre>(apiResponse);
                return genreList;
            }
        }
    }
}
