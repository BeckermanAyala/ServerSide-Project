using Dal.Dalapi;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class SubscriberRepo : ISubscriber
    {
        LibraryContext context;
        public SubscriberRepo(LibraryContext context)
        {
            this.context = context;
        }

            public Subscriber Add(Subscriber subscriber)
        {
            if (context.Subscribers.Find(subscriber) != null)
            {
                context.Subscribers.Add(subscriber);
                context.SaveChanges();
                return subscriber;
            }
            return null;
        }

        public Subscriber Delete(int id)
        {
            Subscriber subscriber = Get(id);
            if (subscriber != null)
            { 
                context.Subscribers.Remove(subscriber);
                context.SaveChanges();

            }
            return subscriber;
        }

        public Subscriber Get(int id)
        {
            return context.Subscribers.Find(id);
        }

        public List<Subscriber> GetAll()
        {
            List<Subscriber> result = context.Subscribers.ToList();
            return result;
        }

        public Subscriber Update(int id, Subscriber subscriber)
        {
            var existingSubscriber = context.Subscribers.FirstOrDefault(c => c.SubscriberId == id);

            if (existingSubscriber != null)
            {
                //existingCourse.CodeCourse = course.CodeCourse;
                //existingCourse.Property2 = course.Property2;
                context.Subscribers.Update(existingSubscriber);
                context.SaveChanges();

                return existingSubscriber;
            }

            return null;
        }
    }
}
    

