using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Error
{
    public int ErrorId { get; set; }

    public string? Error1 { get; set; }

    public DateTime DateCreated { get; set; }
}
