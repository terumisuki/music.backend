using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class SagaTrack
{
    public DateTime TrackAdded { get; set; }

    public string? Title { get; set; }

    public string FileLocation { get; set; } = null!;

    public string? Expr1 { get; set; }

    public int? YearReleased { get; set; }

    public string? Genre { get; set; }

    public string? Mood { get; set; }

    public string? ArtistName { get; set; }

    public string? ArtistEra { get; set; }

    public int MediaId { get; set; }
}
