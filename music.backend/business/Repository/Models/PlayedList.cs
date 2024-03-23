using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class PlayedList
{
    public int Id { get; set; }

    public int? MediaId { get; set; }

    public int? UserId { get; set; }

    public DateTime DateStamp { get; set; }
}
