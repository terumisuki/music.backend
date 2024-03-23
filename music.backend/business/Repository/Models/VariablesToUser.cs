using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class VariablesToUser
{
    public int? UserId { get; set; }

    public int SettingId { get; set; }

    public int VariableId { get; set; }

    public string? TheValue { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual UserSetting Setting { get; set; } = null!;
}
