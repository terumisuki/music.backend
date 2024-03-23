using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class P3Playlist
{
    public int PlaylistId { get; set; }

    public string PlaylistName { get; set; } = null!;

    public int UserId { get; set; }

    public int? GlobalInstructionSetId { get; set; }

    public bool IsDefault { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual P3InstructionSet? GlobalInstructionSet { get; set; }

    public virtual ICollection<P3PlaylistInstructionSet> P3PlaylistInstructionSets { get; set; } = new List<P3PlaylistInstructionSet>();

    public virtual User User { get; set; } = null!;
}
