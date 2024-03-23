using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PhotoAlbumPhoto
{
    public int AlbumId { get; set; }

    public int MediaId { get; set; }

    public string? EnglishCaption { get; set; }

    public string? JapaneseCaption { get; set; }

    public bool? IsActive { get; set; }

    public DateTime Datestamp { get; set; }

    public virtual PhotoAlbum Album { get; set; } = null!;

    public virtual Medium Media { get; set; } = null!;
}
