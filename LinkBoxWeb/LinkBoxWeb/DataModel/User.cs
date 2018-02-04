using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb.DataModel
{
    public class User
    {
        public int Id { get; set; }

        public int Rank { get; set; } 

        public string Username { get; internal set; }
        public string Password { get; internal set; }
    }
}
