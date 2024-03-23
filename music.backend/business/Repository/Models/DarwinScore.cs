using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class DarwinScore
{
    public int UserId { get; set; }

    public int MediaId { get; set; }

    public int DarwinScore1 { get; set; }

    public int? NumberOfTimesSkipped { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual User User { get; set; } = null!;
}
