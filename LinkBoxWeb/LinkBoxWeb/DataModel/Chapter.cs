using System.Collections.Generic;

namespace LinkBoxWeb.DataModel
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Topic Topic { get; set; }

        public List<Link> Links { get; set; }

        public List<Exercise> Exercises { get; set; }
    }
}