using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class MediaType
{
    public int MediaTypeId { get; set; }

    public string MediaType1 { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Medium> Media { get; set; } = new List<Medium>();
}
