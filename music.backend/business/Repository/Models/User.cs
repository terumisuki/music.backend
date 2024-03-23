using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class User
{
    public int UserId { get; set; }

    public int PeopleId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Auth { get; set; }

    public string? Email { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<DarwinScore> DarwinScores { get; set; } = new List<DarwinScore>();

    public virtual ICollection<DynamicPlaylist> DynamicPlaylists { get; set; } = new List<DynamicPlaylist>();

    public virtual ICollection<P3Playlist> P3Playlists { get; set; } = new List<P3Playlist>();

    public virtual Person People { get; set; } = null!;

    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();

    public virtual ICollection<RecentlyPlayedMedium> RecentlyPlayedMedia { get; set; } = new List<RecentlyPlayedMedium>();

    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();
}
