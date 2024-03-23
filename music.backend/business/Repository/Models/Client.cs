using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? Ip { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }
}
