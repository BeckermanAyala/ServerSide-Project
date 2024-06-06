//using BL;
//using BL.BLapi;
//using BL.Bo;
//using Dal.Do;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;

//namespace FitnessGYM.Controllers
//{
//    public class TeachersController : GymController
//    {
//        IFullTeacherRepo fullTeacherRepo;
//        TeachersController(BLManager blManager)
//        {
//            this.fullTeacherRepo = blManager.fullTeacher;
//        }
//        [HttpGet]
//        public ActionResult<List<FullTeacher>> GetTeachers()
//        {
//            if (fullTeacherRepo.GetAll() == null)
//                return NotFound();
//            return fullTeacherRepo.GetAll();
//        }
//    }
//}
using BL;
using BL.BLapi;
using BL.Bo;
using Dal.Do;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FitnessGYM.Controllers
{
    public class TeachersController : GymController
    {
        IFullTeacherRepo fullTeacherRepo;
        public TeachersController(BLManager blManager)
        {
            this.fullTeacherRepo = blManager.fullTeacher;
        }
        [HttpGet]
        public ActionResult<List<FullTeacher>> GetTeachers()
        {
            if (fullTeacherRepo.GetAll() == null)
                return NotFound();
            return fullTeacherRepo.GetAll();
        }
    }
}
