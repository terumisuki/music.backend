using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class DynamicInstruction
{
    public int InstructionId { get; set; }

    public int InstructionSetId { get; set; }

    public int TargetType { get; set; }

    public string? TargetName { get; set; }

    public int TargetId { get; set; }

    public bool OnOff { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual DynamicPlaylistInstructionSet InstructionSet { get; set; } = null!;
}
