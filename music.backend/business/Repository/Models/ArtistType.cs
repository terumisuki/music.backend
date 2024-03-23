using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class ArtistType
{
    public int TypeId { get; set; }

    public int? GracenoteId { get; set; }

    public int? Order { get; set; }

    public string? English { get; set; }

    public string? Japanese { get; set; }

    public DateTime DateStamp { get; set; }
}
