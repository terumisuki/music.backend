using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TaggedMedium
{
    public int TagId { get; set; }

    public int MediaId { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
