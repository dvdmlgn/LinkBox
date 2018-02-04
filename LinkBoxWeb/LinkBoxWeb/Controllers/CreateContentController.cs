using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinkBoxWeb.Extensions;
using LinkBoxWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LinkBoxWeb.Controllers
{
    public class CreateContentController : Controller
    {
        private LinkBoxContext _linkBoxContext;
        public CreateContentController(LinkBoxContext linkBoxContext)
        {
            _linkBoxContext = linkBoxContext;
        }
        // GET: CreateContent
        public ActionResult Index()
        {
            if (this.HttpContext.GetLinkBoxUser(_linkBoxContext) == null)
            {
                return this.RedirectToLinkBoxLogin();
            }

            var createContentViewModel = new CreateContentViewModel();
            createContentViewModel.Subjects = new List<SelectListItem>();
            createContentViewModel.Topics = new List<SelectListItem>();

            bool isFirst = true;
            _linkBoxContext.Subjects.Include(sub => sub.Topics).ToList().ForEach(sub =>
            {
                createContentViewModel.Subjects.Add(new SelectListItem()
                {
                    Value = sub.Id.ToString(),
                    Text = sub.Name
                });

                var selectListGroup = new SelectListGroup()
                {
                    Name = sub.Name,
                    Disabled = !isFirst

                };

                if (isFirst) isFirst = false;

                sub.Topics.ForEach(topic =>
                {
                    createContentViewModel.Topics.Add(new SelectListItem()
                    {
                        Group = selectListGroup,
                        Value = topic.Id.ToString(),
                        Text = topic.Name
                    });
                });

            });

            return View(createContentViewModel);
        }

        // POST: CreateContent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CreateContentViewModel createContentViewModel)
        {
            if (this.HttpContext.GetLinkBoxUser(_linkBoxContext) == null)
            {
                return this.RedirectToLinkBoxLogin();
            }

            return View();
        }
    }
}