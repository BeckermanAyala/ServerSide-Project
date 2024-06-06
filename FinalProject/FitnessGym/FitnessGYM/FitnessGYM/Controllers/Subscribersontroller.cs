using BL.BLapi;
using BL.Bo;
using BL;
using Microsoft.AspNetCore.Mvc;

namespace FitnessGYM.Controllers
{
    public class Subscribersontroller : GymController
    {
        IPersonalSubscriberRepo SubscriberRepo;
        public Subscribersontroller(BLManager blManager)
        {
            this.SubscriberRepo = blManager.personalSubscriber;
        }
        [HttpGet]
        public ActionResult<List<PersonalSubscriber>> GetTeachers()
        {
            if (SubscriberRepo.GetAll() == null)
                return NotFound();
            return SubscriberRepo.GetAll();
        }
    }
}
