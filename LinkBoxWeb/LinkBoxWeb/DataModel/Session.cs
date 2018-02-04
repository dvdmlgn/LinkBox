using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb.DataModel
{
    public class Session
    {
        public int Id { get; set; }

        public string SessionGuid { get; set; }

        public User User { get; set; }
    }
}
