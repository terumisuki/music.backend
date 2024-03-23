using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class RecentlyPlayedMedium
{
    public int MediaId { get; set; }

    public int UserId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual Medium Media { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
