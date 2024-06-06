using AutoMapper;
using BL.BLapi;
using BL.Bo;
using Dal;
using Dal.Dalapi;
using Dal.DalImplementation;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLlmplementaiton
{
    public class FullTeacherRepo : IFullTeacherRepo
    {
        ITeacher teacherRepo;
        ICourses coursesRepo;
        IMapper map;
        public FullTeacherRepo(DalManager dalManager, IMapper map)
        {
            this.teacherRepo = dalManager.teacher;
            this.map = map;
        }


        public List<FullTeacher> GetAll()
        {
            List<FullTeacher> listTeacherBl = new();
            var data = teacherRepo.GetAll();
            data.ForEach(teacher => listTeacherBl.Add(map.Map<FullTeacher>( teacher )));
            return listTeacherBl;

        }

        //FullTeacher IFullTeacherRepo.Get(string name)
        //{

        //    var teacher = teacherRepo.Get(name);

        //    if (teacher == null)
        //    {
        //        return null;
        //    }

        //    FullTeacher fullTeacher = map.Map<FullTeacher>(teacher);


        //    fullTeacher.Courses = map.Map<List<Course>>(teacher.Courses);

        //    return fullTeacher;
        //}
    }



    }

