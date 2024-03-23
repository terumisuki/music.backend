using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string? Tag1 { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<TaggedMedium> TaggedMedia { get; set; } = new List<TaggedMedium>();
}
