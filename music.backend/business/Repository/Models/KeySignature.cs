using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class KeySignature
{
    public int KeyId { get; set; }

    public string? KeySignature1 { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTime DateStamp { get; set; }
}
