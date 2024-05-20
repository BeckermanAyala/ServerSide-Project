using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IFullTeacherRepo
    {
        List<FullTeacher> GetAll();
        FullTeacher Get(int id);
        FullTeacher Add(FullTeacher item);
        FullTeacher Update(int id, FullTeacher item);
        FullTeacher Delete(int id);
    }
}
