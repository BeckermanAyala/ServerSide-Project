using Dal.Dalapi;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class ScheduleRepo : ISchedule
    {
        LibraryContext context;
        public ScheduleRepo(LibraryContext context)
        {
            this.context = context;
        }

            public Schedule Add(Schedule item)
        {
            throw new NotImplementedException();
        }

        public Schedule Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Schedule Get(int CodeSchedule)
        {
            return context.Schedules.Find(CodeSchedule);
        }

        public List<Schedule> GetAll()
        {
            List<Schedule> result = context.Schedules.ToList();
            return result;
        }

        public Schedule Update(int id,Schedule item)
        {
            throw new NotImplementedException();
        }
    }
}
