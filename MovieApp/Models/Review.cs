using System;
using System.Collections.Generic;

namespace MovieApp.Models;

public partial class Review
{
    public int Id { get; set; }

    public string? ImdbId { get; set; }

    public int? Rating { get; set; }

    public string? Review1 { get; set; }
}
