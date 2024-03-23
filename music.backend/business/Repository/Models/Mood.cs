using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Mood
{
    public int MoodId { get; set; }

    public int GracenoteId { get; set; }

    public int Order { get; set; }

    public string English { get; set; } = null!;

    public string Japanese { get; set; } = null!;

    public DateTime DateStamp { get; set; }
}
