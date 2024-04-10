using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public partial class PersonalCourses
    {
        public PersonalCourses(string name, string day)
        {
            this.Name = name;
            this.Day = day; 
        }    
        public string Name { get; set; } = null!;

        public string Day { get; set; } = null!;
    }
}
