using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public partial class PersonalTeacher
    {
        public PersonalTeacher(string lastName, string firstName, string lessonName)
        {
            this.LastName = lastName;
            this.FirstName = firstName; 
            this.LessonName = lessonName;   
        }
        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LessonName { get; set; } = null!;
    }
}
