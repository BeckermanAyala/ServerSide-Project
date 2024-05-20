using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IPersonalSchduleRepo
    {
        List<PersonalSchdule> GetAll();
        PersonalSchdule Get(int id);
        PersonalSchdule Add(PersonalSchdule item);
        PersonalSchdule Update(int id, PersonalSchdule item);
        PersonalSchdule Delete(int id);
    }
}
