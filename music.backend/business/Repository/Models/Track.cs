using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Track
{
    public int MediaId { get; set; }

    public int? ArtistId { get; set; }

    public string? GracenoteId { get; set; }

    public int AlbumId { get; set; }

    public int? TrackNumber { get; set; }

    public int? Volume { get; set; }

    public DateTime? DateStamp { get; set; }
}
