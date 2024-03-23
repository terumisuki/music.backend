using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Part
{
    public int PartId { get; set; }

    public string? Part1 { get; set; }

    public virtual ICollection<MovementsToPart> MovementsToParts { get; set; } = new List<MovementsToPart>();
}
