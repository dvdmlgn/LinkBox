using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb.DataModel
{
    public class Content
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public bool IsExcercise { get; set; }
        public Topic Topic { get; set; }
        public List<UserTags> Tags { get; set; }
        public User User { get; set; }
    }
}
