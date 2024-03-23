using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? Genre1 { get; set; }

    public bool? IsClassical { get; set; }

    public bool? HasMovements { get; set; }

    public int? GracenoteId { get; set; }

    public int? GracenoteOrder { get; set; }

    public int? GracenoteNumber { get; set; }

    public string? Japanese { get; set; }

    public DateTime? DateStamp { get; set; }
}
