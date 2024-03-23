using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PlaylistConjugator
{
    public int ConjugatorId { get; set; }

    public string? Conjugation { get; set; }

    public int? FirstInstructionId { get; set; }

    public int? NextConjugatorId { get; set; }

    public DateTime? DateStamp { get; set; }
}
