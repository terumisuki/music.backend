using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public int? PlaylistVersion { get; set; }

    public int? FirstInstructionSetId { get; set; }

    public int? LastPlayedInstructionSet { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual User User { get; set; } = null!;
}
