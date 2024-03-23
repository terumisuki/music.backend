using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class MovementsToTrack
{
    public int MovementId { get; set; }

    public int? MediaId { get; set; }

    public bool? IsLegacy { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual Movement Movement { get; set; } = null!;
}
