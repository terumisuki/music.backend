using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class DynamicPlaylistGlobal
{
    public int PlaylistGlobalId { get; set; }

    public int PlaylistId { get; set; }

    public int TargetType { get; set; }

    public string? TargetName { get; set; }

    public int TargetId { get; set; }

    public bool OnOff { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual DynamicPlaylist Playlist { get; set; } = null!;
}
