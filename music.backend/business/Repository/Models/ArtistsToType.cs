using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistsToType
{
    public int? ArtistId { get; set; }

    public int? TypeId { get; set; }

    public DateTime? DatStamp { get; set; }

    public virtual Artist? Artist { get; set; }

    public virtual ArtistType? Type { get; set; }
}
