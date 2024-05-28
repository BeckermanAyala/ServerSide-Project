using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
   public partial class FullTeacher
    {
        public FullTeacher(string lastName, string firstName, ICollection<Course> courses)
        { 
            LastName = lastName;

            FirstName = firstName;

            Courses = courses;
        }    
        public string LastName { get; set; }    
        public string FirstName { get; set; }
        public virtual ICollection<Course> Courses { get; set; } 
    }
}
