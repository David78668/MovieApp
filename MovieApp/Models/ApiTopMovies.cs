namespace MovieApp.Models;

public class ApiTopMovie
{
	public string Id { get; set; }
	public string Rank { get; set; }
	public string Title { get; set; }
	public string FullTitle { get; set; }
	public string Year { get; set; }
	public string Image { get; set; }
	public string Crew { get; set; }
	public string ImDbRating { get; set; }
	public string ImDbRatingCount { get; set; }
}

public class ApiTopMovies
{
	public List<ApiTopMovie> Items { get; set; }
	public string ErrorMessage { get; set; }
}