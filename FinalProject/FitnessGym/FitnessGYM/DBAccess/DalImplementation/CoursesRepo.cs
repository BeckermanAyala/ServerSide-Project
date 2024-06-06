using Dal.Dalapi;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //IEnumerable<Course> courses = context.Courses;
            return context.Courses.ToList();
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
        public List<Course> GetCoursesByDay(string day)
        {
            // Get all courses and filter them on the client-side
            return context.Courses.ToList().Where(c => c.Day.Equals(day, StringComparison.OrdinalIgnoreCase)).ToList();
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
