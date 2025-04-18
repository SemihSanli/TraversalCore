using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Traversal_Core.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;

namespace Traversal_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BookingHotelSearchController : Controller
    {
        public async Task< IActionResult> Index()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?children_ages=5%2C0&include_adjacency=true&children_number=2&dest_id=-1456928&adults_number=2&dest_type=city&order_by=popularity&page_number=0&checkout_date=2025-09-26&filter_by_currency=EUR&locale=tr&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&checkin_date=2025-09-25&room_number=1&units=metric"),
                Headers =
    {
        { "x-rapidapi-key", "160c62f520msh829ef427e1a1a14p1c256djsnfbe498e89083" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bodyReplace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
                return View(values.result);
            }
           
        }
        [HttpGet]
        public IActionResult GetCityDestinationID()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetCityDestinationID(string p)
        {
        
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=tr&name={p}"),
                Headers =
    {
        { "x-rapidapi-key", "160c62f520msh829ef427e1a1a14p1c256djsnfbe498e89083" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return View();
            }
        }
    }
}
