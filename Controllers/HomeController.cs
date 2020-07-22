using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ClientData(ClientData dataDetails)
        {
            string city = dataDetails.city;
            string country = dataDetails.country;
            return PartialView("_partialWeatherDetails", await ClientWeatherDetails(city, country));
        }
       public async Task<ClientWeather> ClientWeatherDetails(string city,string country = "")
        {
            string apiKey = "1f495c6d2a740af6cb4ecc8dc5991d2c";
            string location = (country != "" ? city + "," + country : city);
            string apiURL = "https://api.openweathermap.org/data/2.5/weather?q=" + location + "&appid=" + apiKey;
            ClientWeather clientWeather = new ClientWeather();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiURL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    clientWeather = JsonConvert.DeserializeObject<ClientWeather>(apiResponse);
                }
            }
            List<string> locationDetails = new List<string>(location.Split(','));
            if(locationDetails.Count == 2)
            {
                clientWeather.city = locationDetails[0];
                clientWeather.country = locationDetails[1];
            }
            return clientWeather;
        }

        [HttpGet]
        public async Task<IActionResult> GenerateWeatherDetails(string dataDetails)
        {
            return PartialView("_partialWeatherDetails", await ClientWeatherDetails(dataDetails));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
