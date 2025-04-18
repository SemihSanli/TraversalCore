using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using iTextSharp.text;
using Traversal_Core.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traversal_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class MovieAPIController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<MovieAPIViewModel> apiMovies = new List<MovieAPIViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "160c62f520msh829ef427e1a1a14p1c256djsnfbe498e89083" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies=JsonConvert.DeserializeObject<List<MovieAPIViewModel>>(body);
                return View(apiMovies);
            }
        }
    }
}
