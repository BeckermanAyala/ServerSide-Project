using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
   public partial class FullTeacher
    {
        public FullTeacher(string lastName, string firstName)
        { 
            LastName = lastName;

            FirstName = firstName;
        }    
        public string LastName { get; set; }    
        public string FirstName { get; set; }   
    }
}
