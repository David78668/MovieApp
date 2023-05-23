using System;
using System.Collections.Generic;

namespace MovieApp.Models;

public partial class Watchlist
{
    public int Id { get; set; }

    public string? ImdbId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
