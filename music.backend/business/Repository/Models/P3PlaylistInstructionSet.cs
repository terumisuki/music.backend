using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3PlaylistInstructionSet
{
    public int PlaylistInstructionSetId { get; set; }

    public int PlaylistId { get; set; }

    public int InstructionSetId { get; set; }

    public int RotationWeight { get; set; }

    public int? TopXtracks { get; set; }

    public int? PoolCount { get; set; }

    public bool HasHadTurn { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual P3InstructionSet InstructionSet { get; set; } = null!;

    public virtual P3Playlist Playlist { get; set; } = null!;
}
