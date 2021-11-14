using System.Collections.Generic;
using System.Linq;
using LearningPOO.NotificationContext;
using LearningPOO.SharedContext;

namespace LearningPOO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "The student already has an active subscription."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}