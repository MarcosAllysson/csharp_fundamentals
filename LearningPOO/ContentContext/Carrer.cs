using System.Collections.Generic;

namespace LearningPOO.ContentContext
{
    public class Carrer : Content
    {
        public Carrer(string title, string url)
            : base(title: title, url: url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        }
    }
}