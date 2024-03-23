using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Opuse
{
    public int OpusId { get; set; }

    public int? ArtistId { get; set; }

    public string? Title { get; set; }

    public string? Opus { get; set; }

    public string? Number { get; set; }

    public DateTime? DateStamp { get; set; }

    public int? YearReleased { get; set; }

    public bool? IsLegacy { get; set; }

    public int? DisplayOrder { get; set; }

    public virtual ICollection<Piece> Pieces { get; set; } = new List<Piece>();
}
