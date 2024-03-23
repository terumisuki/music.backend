using System;
using System.Collections.Generic;

namespace business.Repository.Models;

public partial class Person
{
    public int PeopleId { get; set; }

    public string? Prefix { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Suffix { get; set; }

    public string? Email { get; set; }

    public string? Ssn { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? DateStamp { get; set; }

    public virtual ICollection<MovementsToPart> MovementsToParts { get; set; } = new List<MovementsToPart>();

    public virtual ICollection<TracksToPerformer> TracksToPerformers { get; set; } = new List<TracksToPerformer>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
