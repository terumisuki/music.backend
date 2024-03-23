using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistsToEra
{
    public int ArtistId { get; set; }

    public int EraId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ArtistEra Era { get; set; } = null!;
}
