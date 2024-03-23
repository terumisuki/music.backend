using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3Conjunction
{
    public int ConjunctionId { get; set; }

    public int InstructionSetId { get; set; }

    public string Conjunction { get; set; } = null!;

    public DateTime DateStamp { get; set; }

    public virtual P3InstructionSet InstructionSet { get; set; } = null!;

    public virtual ICollection<P3Instruction> P3Instructions { get; set; } = new List<P3Instruction>();
}
