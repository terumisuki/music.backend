using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TracksToTempo
{
    public int MediaId { get; set; }

    public int TempoId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual Tempo Tempo { get; set; } = null!;
}
