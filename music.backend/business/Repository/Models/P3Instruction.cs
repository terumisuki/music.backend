using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3Instruction
{
    public int Instructionid { get; set; }

    public int InstructionTypeId { get; set; }

    public int ConjunctionId { get; set; }

    public int? TargetType { get; set; }

    public string? TargetName { get; set; }

    public int? TargetId { get; set; }

    public bool OnOff { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual P3Conjunction Conjunction { get; set; } = null!;

    public virtual P3InstructionType InstructionType { get; set; } = null!;

    public virtual ICollection<P3RecentEntry> P3RecentEntries { get; set; } = new List<P3RecentEntry>();

    public virtual ICollection<P3Year> P3Years { get; set; } = new List<P3Year>();
}
