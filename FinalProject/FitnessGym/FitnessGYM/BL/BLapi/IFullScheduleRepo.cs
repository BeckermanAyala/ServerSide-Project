using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IFullScheduleRepo
    {
        List<FullSchedule> GetAll();
        FullSchedule Get(DateTime date);
        FullSchedule Add(FullSchedule item);
        FullSchedule Update(DateTime date, FullSchedule item);
        FullSchedule Delete(DateTime date);
    }
}
