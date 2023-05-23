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
			return (_database.Watchlists.ToList());
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
			return (_database.Reviews.Where(r => r.ImdbId == id).ToList());
		}

		//Function for adding a review to a movie
		public void AddReview(Review review)
		{
			_database.Reviews.Add(review);
			_database.SaveChanges();
		}

		//Function fro removing movies from the watchlist
		public void RemoveFromWatchlist(int id)
		{
			_database.Watchlists.Remove(_database.Watchlists.FirstOrDefault(w => w.Id == id));
			_database.SaveChanges();
		}

		//Function thath updates the top 250 movies in the database
		public void SaveTopMovies(List<ApiTopMovie> apiTopMovies)
		{
			_database.TopMovies.RemoveRange(_database.TopMovies);
			foreach (ApiTopMovie movie in apiTopMovies)
			{
				TopMovies tempTopMovie = new() { ImdbId = movie.Id, Rank = movie.Rank, Title = movie.Title, FullTitle = movie.FullTitle, Year = movie.Year, Image = movie.Image, Crew = movie.Crew, ImdbRating = movie.ImDbRating, ImdbRatingCount = movie.ImDbRatingCount };
				_database.Add(tempTopMovie);
			}
			_database.SaveChanges();
		}
	}
}
