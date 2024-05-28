using Dal.Dalapi;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class TeacherRepo : ITeacher
    {
        LibraryContext context;
            public TeacherRepo(LibraryContext context)
        {
            this.context = context; 
        }
        public Teacher Add(Teacher teacher)
        {
            if (context.Teachers.Find(teacher) != null)
            {
                context.Teachers.Add(teacher);
                context.SaveChanges();
                return teacher;
            }
            return null;
        }

        public Teacher Delete(int id)
        {
            Teacher teacher= Get(id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            return teacher;
         }

        public Teacher Get(string name)
        {
            return context.Teachers.Find(name);
        }

        public List<Teacher> GetAll()
        {
            List<Teacher> result = context.Teachers.ToList();
            return result;
        }

        public Teacher Update(int id, Teacher teacher)
        {
            var existingTeacher = context.Teachers.FirstOrDefault(c => c.TeachersId == id);

            if (existingTeacher != null)
            {
                //existingCourse.CodeCourse = course.CodeCourse;
                //existingCourse.Property2 = course.Property2;
                context.Teachers.Update(existingTeacher);
                context.SaveChanges();

                return existingTeacher;
            }

            return null;
        }
    }
}
