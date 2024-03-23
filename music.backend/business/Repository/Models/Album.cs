using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Album
{
    public int AlbumId { get; set; }

    public string? GracenoteId { get; set; }

    public int? ArtistId { get; set; }

    public string? Title { get; set; }

    public int? YearReleased { get; set; }

    public DateTime? DateStamp { get; set; }
}
