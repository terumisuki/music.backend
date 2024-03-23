using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Movement
{
    public int MovementId { get; set; }

    public int? PieceId { get; set; }

    public int? Number { get; set; }

    public string? Title { get; set; }

    public int? SortNumber { get; set; }

    public bool? IsLegacy { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<MovementsToPart> MovementsToParts { get; set; } = new List<MovementsToPart>();

    public virtual Piece? Piece { get; set; }
}
