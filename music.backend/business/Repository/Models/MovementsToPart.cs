using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class MovementsToPart
{
    public int Id { get; set; }

    public int? MovementId { get; set; }

    public int? PartId { get; set; }

    public int? ComposedBy { get; set; }

    public int? ComposedAs { get; set; }

    public bool? IsLegacy { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual Artist? ComposedAsNavigation { get; set; }

    public virtual Person? ComposedByNavigation { get; set; }

    public virtual Movement? Movement { get; set; }

    public virtual Part? Part { get; set; }
}
