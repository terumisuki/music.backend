using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Variable
{
    public int VariableId { get; set; }

    public string TheKey { get; set; } = null!;

    public string? TheValue { get; set; }
}
