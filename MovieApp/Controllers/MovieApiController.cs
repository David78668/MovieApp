using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;

namespace MovieApp.Controllers
{
<<<<<<< HEAD
    [ApiController]
=======
	[ApiController]
>>>>>>> a8ed6b4471308c552fab4e9b303e26967f16785c
	[Route("movie")]
	public class MovieApiController : Controller
	{
		private readonly DatabaseService dbService;

		public MovieApiController(DatabaseService databaseService)
		{
			dbService = databaseService;
		}

		[HttpGet("/GetWatchlist")]
		public IActionResult GetWatchlist()
		{
			var data = dbService.GetWatchlist();
			return Ok(data);
		}

		[HttpPost("/AddToWatchlist")]
		public IActionResult AddToWatchlist(Watchlist movie)
		{
			dbService.AddToWatchlist(movie);
			return Ok();
		}

		[HttpGet("/GetReviews")]
		public IActionResult Delete(string id)
		{
			var data = dbService.GetReviews(id);
			return Ok(data);
		}

		[HttpPost("/AddReview")]
		public IActionResult AddReview(Review review)
		{
			dbService.AddReview(review);
			return Ok();
		}
	}
}
