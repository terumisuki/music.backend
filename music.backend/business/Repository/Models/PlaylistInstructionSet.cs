using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PlaylistInstructionSet
{
    public int InstructionSetId { get; set; }

    public int? FirstConjugationId { get; set; }

    public int RotationWeight { get; set; }

    public int? NextInstructionSetId { get; set; }

    public DateTime Datestamp { get; set; }
}
