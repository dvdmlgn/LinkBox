using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace LinkBoxWeb.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsIncorrectPasswordOrUsernameTaken { get; set; }
        public bool IsInvalid { get; set; }
        public string RouteValueDictionary { get; set; }
        public bool Successful { get; internal set; }
    }
}
