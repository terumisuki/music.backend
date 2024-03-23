using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Piece
{
    public int PieceId { get; set; }

    public int? ArtistId { get; set; }

    public int? CompositionalStyleId { get; set; }

    public int? OpusId { get; set; }

    public int? Number { get; set; }

    public string? Title { get; set; }

    public int? KeyId { get; set; }

    public string? KeySignature { get; set; }

    public int? PieceTypeId { get; set; }

    public int? GroupingNumber { get; set; }

    public int? SortNumber { get; set; }

    public bool? IsLegacy { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual Opuse? Opus { get; set; }
}
