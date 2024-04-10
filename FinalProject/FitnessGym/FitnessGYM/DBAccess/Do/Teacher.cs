using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Teacher
{
    public int TeachersId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LessonName { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
