using System.Collections.Generic;

namespace LinkBoxWeb.DataModel
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject Subject { get; set; }
        public List<Content> Contents { get; set; }
    }
}