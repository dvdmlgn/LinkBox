using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb.DataModel
{
    public class Content
    {
        public int Id { get; set; }

        public Chapter Chapter { get; set; }

        public List<UserTags> Tags { get; set; }
    }
}
