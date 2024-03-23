using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistsToOrigin
{
    public int ArtistId { get; set; }

    public int OriginId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual ArtistOrigin Origin { get; set; } = null!;
}
