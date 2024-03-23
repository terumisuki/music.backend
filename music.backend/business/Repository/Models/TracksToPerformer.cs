using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TracksToPerformer
{
    public int Id { get; set; }

    public int? MediaId { get; set; }

    public int? PartId { get; set; }

    public int? PerformedBy { get; set; }

    public int? PerformedAs { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual Artist? PerformedAsNavigation { get; set; }

    public virtual Person? PerformedByNavigation { get; set; }
}
