using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TrackGrade
{
    public int UserId { get; set; }

    public int? Grade { get; set; }

    public DateTime? DateStamp { get; set; }

    public int? MediaId { get; set; }

    public virtual Medium? Media { get; set; }
}
