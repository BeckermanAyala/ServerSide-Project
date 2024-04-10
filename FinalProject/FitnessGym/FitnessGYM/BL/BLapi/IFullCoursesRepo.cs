using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IFullCoursesRepo
    {
        List<FullCourses> GetAll();
        FullCourses Get(int id);
        FullCourses Add(FullCourses item);
        FullCourses Update(int id, FullCourses item);
        FullCourses Delete(int id);
    }
}
