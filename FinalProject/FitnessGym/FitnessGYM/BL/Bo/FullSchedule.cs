using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public partial class FullSchedule
    {
        public FullSchedule(DateTime date) 
        {
           Date = date; 
        }   
        public DateTime Date { get; set; }  
    }
}
