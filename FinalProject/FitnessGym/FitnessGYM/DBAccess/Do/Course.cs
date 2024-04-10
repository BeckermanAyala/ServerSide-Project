using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Course
{
    public int CodeCourse { get; set; }

    public string Name { get; set; } = null!;

    public int MaxParticipants { get; set; }

    public string Day { get; set; } = null!;

    public virtual Teacher NameNavigation { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
