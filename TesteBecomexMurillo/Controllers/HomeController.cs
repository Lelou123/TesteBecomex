using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RESTCountries.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TesteBecomexMurillo.Models;
using RESTCountries.Models;


namespace TesteBecomexMurillo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            List<Country> countries = await RESTCountriesAPI.GetAllCountriesAsync();
            
            return View(countries);            
        }


        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search([FromBody] Pais x)
		{

            string a = x.Buscar;
            
            List<Country> result = await RESTCountriesAPI.GetCountriesByNameContainsAsync(a);

           x.teste = result;
            return View(x.teste);
                
		}



        [HttpGet]
        public async Task<IActionResult> PaisEspAsync(string Pais)
        {            
            Country result = await RESTCountriesAPI.GetCountryByFullNameAsync(Pais);
            
            List<Country> countries = new List<Country>();
            countries.Add(result);

            return View(countries);
        }

        


        public IActionResult Privacy()
        {
            return View();
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
