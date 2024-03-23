using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistOrigin
{
    public int ArtistOriginId { get; set; }

    public int? GracenoteOriginId { get; set; }

    public int? Order { get; set; }

    public string? English { get; set; }

    public string? Japanese { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual ICollection<ArtistsToOrigin> ArtistsToOrigins { get; set; } = new List<ArtistsToOrigin>();
}
