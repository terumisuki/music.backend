using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Artist
{
    public int ArtistId { get; set; }

    public string? GracenoteId { get; set; }

    public string Name { get; set; } = null!;

    public string? JapaneseName { get; set; }

    public bool? IsClassical { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<ArtistsToEra> ArtistsToEras { get; set; } = new List<ArtistsToEra>();

    public virtual ICollection<ArtistsToOrigin> ArtistsToOrigins { get; set; } = new List<ArtistsToOrigin>();

    public virtual ICollection<MovementsToPart> MovementsToParts { get; set; } = new List<MovementsToPart>();

    public virtual ICollection<TracksToPerformer> TracksToPerformers { get; set; } = new List<TracksToPerformer>();
}
