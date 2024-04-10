using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public partial class FullCourses
    {

        public FullCourses(string name, string day)
        {
            Name = name;
            Day = day;

        }
    
        public string Name { get; set; } = null!;

        public string Day { get; set; } = null!;



    }
}
