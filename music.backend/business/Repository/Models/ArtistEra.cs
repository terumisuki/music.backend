using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistEra
{
    public int EraId { get; set; }

    public int? GracenoteId { get; set; }

    public int? Order { get; set; }

    public string English { get; set; } = null!;

    public string Japanese { get; set; } = null!;

    public DateTime DateStamp { get; set; }

    public virtual ICollection<ArtistsToEra> ArtistsToEras { get; set; } = new List<ArtistsToEra>();
}
