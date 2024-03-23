using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class SyncdWithPhone
{
    public int MediaId { get; set; }

    public int? UserId { get; set; }

    public int? DeviceId { get; set; }

    public DateTime DateStamp { get; set; }
}
