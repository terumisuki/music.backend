using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3InstructionSet
{
    public int InstructionSetId { get; set; }

    public string InstructionSetName { get; set; } = null!;

    public int? PoolCount { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual ICollection<P3Conjunction> P3Conjunctions { get; set; } = new List<P3Conjunction>();

    public virtual ICollection<P3PlaylistInstructionSet> P3PlaylistInstructionSets { get; set; } = new List<P3PlaylistInstructionSet>();

    public virtual ICollection<P3Playlist> P3Playlists { get; set; } = new List<P3Playlist>();
}
