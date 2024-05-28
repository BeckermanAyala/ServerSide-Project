using BL.BLapi;
using BL.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DalImplementation;
using Dal.Dalapi;
using AutoMapper;
using Dal;
using Dal.Do;


namespace BL.BLlmplementaiton
{
    public class FullCoursesRepo : IFullCoursesRepo
    {
        ICourses coursesRepo;
        IMapper map;

        public FullCoursesRepo(DalManager dalManager, IMapper map)
        {
            this.coursesRepo = dalManager.courses;
            this.map = map;
        }


    
        //public FullCourses Add(Course course)
        //{
        //    Dal.Do.Course course1=map.Map<Dal.Do.Course>(course);
        //    coursesRepo.Add(course1);
        //    Bo.FullCourses course2 = map.Map<Bo.FullCourses>(course1);
        //    return course2;
        //    //לא מספיק ברור
        //}




        public List<FullCourses> GetAll()
        {
            List<FullCourses> listBl = new();
            var data = coursesRepo.GetAll();
            data.ForEach(course => listBl.Add(map.Map<FullCourses>(course)));
            return listBl;  
        }

    }
}
