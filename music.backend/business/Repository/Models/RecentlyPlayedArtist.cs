using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class RecentlyPlayedArtist
{
    public int? ArtistId { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateStamp { get; set; }
}
