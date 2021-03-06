﻿using System.Collections.Generic;

namespace LinkBoxWeb.DataModel
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Site Site { get; set; }

        public List<Topic> Topics { get; set; }
    }
}