using Dal.Dalapi;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class CoursesRepo : ICourses
    {
        LibraryContext context;
        public CoursesRepo(LibraryContext context)
        {
            this.context = context; 
        } 
        public  List<Course> GetAll()
        {
            List<Course> result = context.Courses.ToList();
            return result;
        }

        public Course Get(int CodeCourse)
        {
            return context.Courses.Find(CodeCourse);
        }

        public Course Add(Course course)
        {
            if (context.Courses.Find(course)!= null) { 
            context.Courses.Add(course);
            context.SaveChanges();
            return course;    
        }
            return null;
        }

        public Course Update(int CodeCourse, Course course)
        {
            var existingCourse = context.Courses.FirstOrDefault(c => c.CodeCourse == CodeCourse);

            if (existingCourse != null)
            {
                //existingCourse.CodeCourse = course.CodeCourse;
                //existingCourse.Property2 = course.Property2;
                context.Courses.Update(existingCourse);
                context.SaveChanges();

                return existingCourse;
            }

            return null; 
        }

        public Course Delete(int id)
        {
            Course course = Get(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();  
                
            }
                return course; 
        }
    }
}
