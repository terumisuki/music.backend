using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PhotoAlbum
{
    public int AlbumId { get; set; }

    public string? Name { get; set; }

    public string AlbumCode { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public virtual ICollection<PhotoAlbumPhoto> PhotoAlbumPhotos { get; set; } = new List<PhotoAlbumPhoto>();
}
