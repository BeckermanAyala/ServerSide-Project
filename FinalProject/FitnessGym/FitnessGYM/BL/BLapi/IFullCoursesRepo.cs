using BL.Bo;
using Dal.Do;
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
        List<string> GetCourseNamesByDay(string day);
        //FullCourses Get(int id);
        //FullCourses Add(FullCourses item);
        //FullCourses Update(int id, FullCourses item);
        //FullCourses Delete(int id);
    }
}
