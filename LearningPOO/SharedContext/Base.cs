using System;
using LearningPOO.NotificationContext;

namespace LearningPOO.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // generating a hash automatically.
        }
        public Guid Id { get; set; }
    }

}