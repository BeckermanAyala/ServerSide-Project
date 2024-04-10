using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class ParticipantsInTheCourse
{
    public int CodeParticipant { get; set; }

    public int CodeSchedule { get; set; }

    public virtual Subscriber CodeParticipantNavigation { get; set; } = null!;

    public virtual Schedule CodeScheduleNavigation { get; set; } = null!;
}
