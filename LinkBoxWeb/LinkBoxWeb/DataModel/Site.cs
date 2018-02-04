using System.Collections.Generic;

namespace LinkBoxWeb.DataModel
{
    public class Site
    {
        public int SiteId { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}