using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PlaylistInstruction
{
    public int InstructionId { get; set; }

    public string? Conjugation { get; set; }

    public int? TargetTypeId { get; set; }

    public int? TargetId { get; set; }

    public bool OnOff { get; set; }

    public int? NextInstructionId { get; set; }

    public DateTime DateStamp { get; set; }
}
