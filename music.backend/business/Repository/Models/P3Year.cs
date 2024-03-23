using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3Year
{
    public int YearId { get; set; }

    public int InstructionId { get; set; }

    public int YearFrom { get; set; }

    public int YearTo { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual P3Instruction Instruction { get; set; } = null!;
}
