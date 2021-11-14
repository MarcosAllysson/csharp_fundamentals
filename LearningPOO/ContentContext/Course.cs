using System.Collections.Generic;
using LearningPOO.ContentContext.Enums;

namespace LearningPOO.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url)
            : base(title: title, url: url)
        {
            // Its recommended to always initialize a list.
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}