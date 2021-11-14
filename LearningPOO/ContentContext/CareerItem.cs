using System;
using LearningPOO.NotificationContext;
using LearningPOO.SharedContext;

namespace LearningPOO.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                // throw new Exception("The course can not be empty");
                AddNotification(new Notification("Course", "Invalid course."));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

        public void CareerItemFullDetail()
        {
            Console.WriteLine($"Order: {Order}; \nTitle: {Title}; \nDescription: {Description}; \nCourse: {Course?.Title}");
            // ? -> it is used to deal when an object is null. If it is, shows nothing.
            // Console.Write('\n');
        }
    }
}