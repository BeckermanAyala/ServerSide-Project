using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Schedule
{
    public DateTime Date { get; set; }

    public int CodeSchedule { get; set; }

    public int CodeCourse { get; set; }

    public virtual Course CodeCourseNavigation { get; set; } = null!;
}
