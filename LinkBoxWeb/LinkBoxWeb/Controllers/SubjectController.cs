using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LinkBoxWeb.Models;
using LinkBoxWeb.Extensions;

namespace LinkBoxWeb.Controllers
{
    public class SubjectController : Controller
    {
        private LinkBoxContext _linkBoxContext;
        public SubjectController(LinkBoxContext linkBoxContext)
        {
            _linkBoxContext = linkBoxContext;
        }
        public ActionResult Index()
        {
            if(this.HttpContext.GetLinkBoxUser(_linkBoxContext) == null)
            {
                return this.RedirectToLinkBoxLogin();
            }

            return View();
        }
    }
}