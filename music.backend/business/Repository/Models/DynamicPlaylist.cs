using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class DynamicPlaylist
{
    public int PlaylistId { get; set; }

    public int UserId { get; set; }

    public string PlaylistName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual ICollection<DynamicPlaylistGlobal> DynamicPlaylistGlobals { get; set; } = new List<DynamicPlaylistGlobal>();

    public virtual ICollection<DynamicPlaylistInstructionSet> DynamicPlaylistInstructionSets { get; set; } = new List<DynamicPlaylistInstructionSet>();

    public virtual User User { get; set; } = null!;
}
