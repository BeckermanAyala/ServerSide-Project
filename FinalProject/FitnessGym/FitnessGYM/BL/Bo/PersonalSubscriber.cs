using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bo
{
    public partial class PersonalSubscriber
    {
        public PersonalSubscriber(string lastName, string firstName, string subscriptionType, DateTime dateOfSubscription)
        {
            this.LastName = lastName;   
            this.FirstName = firstName; 
            this.SubscriptionType = subscriptionType;   
            this.DateOfSubscription = dateOfSubscription;
        }

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;


        public string SubscriptionType { get; set; } = null!;

        public DateTime DateOfSubscription { get; set; }
    }
}
