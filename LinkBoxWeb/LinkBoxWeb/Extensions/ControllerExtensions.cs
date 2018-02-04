using LinkBoxWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LinkBoxWeb.Extensions
{
    public static class ControllerExtensions
    {
        public static RedirectToActionResult RedirectToLinkBoxLogin(this Controller controller)
        {
            var a = HttpUtility.UrlEncode(JsonConvert.SerializeObject(controller.RouteData.Values));

            return controller.RedirectToAction("LoginRedirect", "Account", new LoginViewModel()
            {
                RouteValueDictionary = HttpUtility.UrlEncode(JsonConvert.SerializeObject(controller.RouteData.Values))
            });
        }
    }
}
