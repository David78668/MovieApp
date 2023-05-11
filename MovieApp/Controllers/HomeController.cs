using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;
using System.Diagnostics;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ImdbApiService _api;

        public HomeController(ILogger<HomeController> logger, ImdbApiService api)
        {
            _logger = logger;
            _api = api;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Search(string input)
        {
            var searchData = _api.Search(input).GetAwaiter().GetResult();
            return View(searchData);
        }

        public IActionResult Detail(string id)
        {
            var movieData = _api.GetMovie(id).GetAwaiter().GetResult();
            return View(movieData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}