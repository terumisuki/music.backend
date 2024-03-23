using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Medium
{
    public int MediaId { get; set; }

    public int MediaTypeId { get; set; }

    public string FileLocation { get; set; } = null!;

    public string? Title { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual MediaType MediaType { get; set; } = null!;

    public virtual ICollection<PhotoAlbumPhoto> PhotoAlbumPhotos { get; set; } = new List<PhotoAlbumPhoto>();

    public virtual ICollection<RecentlyPlayedMedium> RecentlyPlayedMedia { get; set; } = new List<RecentlyPlayedMedium>();

    public virtual ICollection<TaggedMedium> TaggedMedia { get; set; } = new List<TaggedMedium>();

    public virtual ICollection<TracksToTempo> TracksToTempos { get; set; } = new List<TracksToTempo>();
}
