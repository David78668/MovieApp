using Azure;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;
using System.Diagnostics;
using System.Net.Http;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ImdbApiService _api;
        private readonly DatabaseService _databaseService;
        private readonly MovieApiController _databaseApi;
        
		public HomeController(
            ILogger<HomeController> logger, 
            ImdbApiService api, 
            DatabaseService databaseService, 
            MovieApiController databaseApi)
        {
            _logger = logger;
            _api = api;
            _databaseApi = databaseApi;
            _databaseService = databaseService;
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

        public IActionResult Watchlist()
        {
			return View(_databaseService.GetWatchlist());
		}

        public IActionResult Reviews(string id, string movie)
        {
            return View(_databaseService.GetReviews(id));
        }

		public IActionResult WriteReview(string id)
		{
			return View(_databaseService.GetReviews(id));
		}

		[HttpPost]
        public IActionResult AddToWatchlist(string Id, string Title, string Description, string Image)
        {
            Watchlist Movie = new() { ImdbId = Id, Title = Title, Description = Description, Image = Image };
            _databaseService.AddToWatchlist(Movie);
            return RedirectToAction("Watchlist");
        }

        [HttpPost]
        public IActionResult WriteReview(string ImdbId, int rating, string review1) 
        {
            Review review = new() { ImdbId = ImdbId, Rating = rating, Review1 = review1 };
            _databaseService.AddReview(review);
			return Redirect($"Reviews?id={ImdbId}");
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}