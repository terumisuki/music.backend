using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class TracksToMood
{
    public int MediaId { get; set; }

    public int MoodId { get; set; }

    public DateTime DateStamp { get; set; }
}
