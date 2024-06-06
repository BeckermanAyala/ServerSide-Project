using BL;
using BL.BLapi;
using BL.Bo;
using Dal.Do;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FitnessGYM.Controllers
{
    public class CoursesController :GymController
    {
        IFullCoursesRepo fullCoursesRepo;
        public CoursesController(BLManager blManager)
        {
            this.fullCoursesRepo = blManager.fullCourses;
        }
        [HttpGet]
        public ActionResult <List<FullCourses>>GetCourses() {
            if (fullCoursesRepo.GetAll() == null)
                return NotFound();
            return fullCoursesRepo.GetAll();
            }
        [HttpGet("day/{day}")]
        public ActionResult<List<string>> GetCoursesByDay(string day)
        {
            var courseNames = fullCoursesRepo.GetCourseNamesByDay(day);
            if (courseNames == null)
                return NotFound("No courses found for the specified day.");

            return Ok(courseNames);
        }

    }
}
