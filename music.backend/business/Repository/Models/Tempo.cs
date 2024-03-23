using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Tempo
{
    public int TempoId { get; set; }

    public int GracenoteId { get; set; }

    public string? English { get; set; }

    public string? Japanese { get; set; }

    public int? Tempo1 { get; set; }

    public int? Order { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual ICollection<TracksToTempo> TracksToTempos { get; set; } = new List<TracksToTempo>();
}
