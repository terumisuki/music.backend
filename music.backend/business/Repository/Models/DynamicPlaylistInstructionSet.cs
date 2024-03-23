using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class DynamicPlaylistInstructionSet
{
    public int InstructionSetId { get; set; }

    public int PlaylistId { get; set; }

    public int RotationWeight { get; set; }

    public int? TopXtracks { get; set; }

    public int? PoolCount { get; set; }

    public bool InstructionSetPlayed { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual ICollection<DynamicInstruction> DynamicInstructions { get; set; } = new List<DynamicInstruction>();

    public virtual DynamicPlaylist Playlist { get; set; } = null!;
}
