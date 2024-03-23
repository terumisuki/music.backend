using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class UserSetting
{
    public int SettingId { get; set; }

    public string? SettingName { get; set; }

    public int UserId { get; set; }

    public DateTime DateStamp { get; set; }

    public virtual User User { get; set; } = null!;
}
