using System;
using System.Collections.Generic;

namespace MovieApp.Models;

public partial class TopMovies
{
    public int Id { get; set; }

    public string? ImdbId { get; set; }

    public string? Rank { get; set; }

    public string? Title { get; set; }

    public string? FullTitle { get; set; }

    public string? Year { get; set; }

    public string? Image { get; set; }

    public string? Crew { get; set; }

    public string? ImdbRating { get; set; }

    public string? ImdbRatingCount { get; set; }
}
