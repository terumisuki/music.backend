using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TracksToGenre
{
    public int GenreId { get; set; }

    public int MediaId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual Medium Media { get; set; } = null!;
}
