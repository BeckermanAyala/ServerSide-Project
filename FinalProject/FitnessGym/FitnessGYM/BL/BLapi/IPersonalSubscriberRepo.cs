using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IPersonalSubscriberRepo
    {
        List<PersonalSubscriber> GetAll();
        //PersonalSubscriber Get(int id);
        //PersonalSubscriber Add(PersonalSubscriber item);
        //PersonalSubscriber Update(int id, PersonalSubscriber item);
        //PersonalSubscriber Delete(int id);
    }
}
