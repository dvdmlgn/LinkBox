using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using LinkBoxWeb.Models;
using LinkBoxWeb.DataModel;
using LinkBoxWeb.Constants;
using Microsoft.AspNetCore.Routing;
using System.Web;
using Newtonsoft.Json;

namespace LinkBoxWeb.Controllers
{
    public class AccountController : Controller
    {
        private LinkBoxContext _linkBoxContext;
        public AccountController(LinkBoxContext linkBoxContext)
        {
            _linkBoxContext = linkBoxContext;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpGet]
        public ActionResult LoginRedirect(LoginViewModel loginViewModel)
        {
            if (loginViewModel == null)
                loginViewModel = new LoginViewModel();

            return View("Login", loginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            var passwordCopy = loginViewModel.Password;
            loginViewModel.Password = "";

            loginViewModel.IsIncorrectPasswordOrUsernameTaken = false;
            loginViewModel.IsInvalid = false;
            loginViewModel.Successful = false;

            if (string.IsNullOrWhiteSpace(loginViewModel.Username) || string.IsNullOrWhiteSpace(passwordCopy))
            {
                loginViewModel.IsInvalid = true;
                return View(loginViewModel);
            }

            var user = _linkBoxContext.Users.FirstOrDefault(_user => _user.Username == loginViewModel.Username);
            if (user != null)
            {
                if (user.Password != passwordCopy)
                {
                    loginViewModel.IsIncorrectPasswordOrUsernameTaken = true;
                    return View(loginViewModel);
                }
            }
            else
            {
                user = new User()
                {
                    Username = loginViewModel.Username,
                    Password = passwordCopy
                };

                // There is a race condition here ;)
                _linkBoxContext.Users.Add(user);
                _linkBoxContext.SaveChanges();
            }

            var session = new Session()
            {
                User = user
            };

            _linkBoxContext.Sessions.Add(session);
            _linkBoxContext.SaveChanges();

            Response.Cookies.Append(MagicStrings.SessionGuidKey, session.SessionGuid.ToString());

            loginViewModel.Successful = true;

            if (loginViewModel.RouteValueDictionary != null)
            {
                var routeValueDictionary = JsonConvert.DeserializeObject<RouteValueDictionary>(
                    HttpUtility.UrlDecode(loginViewModel.RouteValueDictionary));

                return RedirectToRoute(routeValueDictionary);
            }
            else
            {

                return View(loginViewModel);
            }
        }
    }
}