using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3InstructionType
{
    public int InstructionTypeId { get; set; }

    public string Type { get; set; } = null!;

    public DateTime DateStamp { get; set; }

    public virtual ICollection<P3Instruction> P3Instructions { get; set; } = new List<P3Instruction>();
}
