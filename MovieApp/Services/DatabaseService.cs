using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieApp.Models;

namespace MovieApp.Services
{
	public class DatabaseService
	{
		private readonly MovieAppDbContext _database;

		public DatabaseService(MovieAppDbContext database)
		{
			_database = database;
		}
		
		//Function for returning every movie from the watchlist
		public List<Watchlist> GetWatchlist()
		{
			return(_database.Watchlists.ToList());
		}

		//Function for adding a movie to the watchlist
		public void AddToWatchlist(Watchlist Movie)
		{
			_database.Watchlists.Add(Movie);
			_database.SaveChanges();
		}

		//Function for getting all reviews of a specific movie by the ImdbID
		public List<Review> GetReviews(string id)
		{
			return(_database.Reviews.Where(r => r.ImdbId == id).ToList());
		}

		//Function for adding a review to a movie
		public void AddReview(Review review)
		{
			_database.Reviews.Add(review);
			_database.SaveChanges();
		}
	}
}
