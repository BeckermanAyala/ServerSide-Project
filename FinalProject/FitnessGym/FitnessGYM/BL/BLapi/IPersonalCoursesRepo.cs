using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLapi
{
    public interface IPersonalCoursesRepo
    {
        List<PersonalCourses> GetAll();
        PersonalCourses Get(int id);
        PersonalCourses Add(PersonalCourses item);
        PersonalCourses Update(int id, PersonalCourses item);
        PersonalCourses Delete(int id);
    }
}
