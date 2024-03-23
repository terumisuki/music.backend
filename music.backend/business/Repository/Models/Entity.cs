using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Entity
{
    public int EntityId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime DateStamp { get; set; }
}
