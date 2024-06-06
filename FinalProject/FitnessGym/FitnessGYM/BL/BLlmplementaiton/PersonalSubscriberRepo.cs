using AutoMapper;
using BL.BLapi;
using BL.Bo;
using Dal.Dalapi;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DalImplementation;
using Dal.Do;
namespace BL.BLlmplementaiton
{
    public class PersonalSubscriberRepo : IPersonalSubscriberRepo { 
        
    ISubscriber subscriberRepo;
    IMapper map;
    public PersonalSubscriberRepo(DalManager dalManager, IMapper map)
    {
        this.subscriberRepo = dalManager.subscriber;
        this.map = map;
    }
   
        //PersonalSubscriber IPersonalSubscriberRepo.Add(PersonalSubscriber item)
        //{
        //    throw new NotImplementedException();
        //}

        //PersonalSubscriber IPersonalSubscriberRepo.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //PersonalSubscriber IPersonalSubscriberRepo.Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public List<PersonalSubscriber> GetAll()
        {
            List<PersonalSubscriber> listBl = new();
            var data = subscriberRepo.GetAll();
            data.ForEach(subscriber => listBl.Add(map.Map<PersonalSubscriber>(subscriber)));
            return listBl;
        }

        //PersonalSubscriber IPersonalSubscriberRepo.Update(int id, PersonalSubscriber item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
