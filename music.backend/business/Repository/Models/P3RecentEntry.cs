using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3RecentEntry
{
    public int RecentId { get; set; }

    public int InstructionId { get; set; }

    public DateOnly FromDate { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual P3Instruction Instruction { get; set; } = null!;
}
