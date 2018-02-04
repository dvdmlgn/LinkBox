using LinkBoxWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LinkBoxWeb.Controllers
{
    public class HomeController : Controller
    {
        private LinkBoxContext _linkBoxContext;

        public HomeController(LinkBoxContext linkBoxContext)
        {
            _linkBoxContext = linkBoxContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<my> mys = _linkBoxContext
                .Contents
                .Include(cont => cont.Topic)
                .Include(cont => cont.Topic.Subject)
                .ToList().Select(ex => 
            new my() {
                Subject = ex.Topic.Subject.Name,
                Topic = ex.Topic.Name,
                Description = ex.Description,
                isExercise = true,
                Votes = 70,
                ResourceType = ex.IsExcercise ? "Excercise" : "Library",
                Content = ex.Href
            }).ToList();
            
            return View(mys);
        }

        public IActionResult Profile()
        {
            List<ProfileModel> mys = new List<ProfileModel>();
            mys.Add(new ProfileModel()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = false,

                Votes = 70,

                ResourceType = "Exercise",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new ProfileModel()
            {
                Subject = "Accounting",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = false,

                Votes = 54,

                ResourceType = "Exercise",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new ProfileModel()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = false,

                Votes = 32,

                ResourceType = "Exercise",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new ProfileModel()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = false,

                Votes = 29,
                ResourceType = "Library",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new ProfileModel()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = true,

                Votes = 24,

                ResourceType = "Exercise",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new ProfileModel()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                isExercise = true,

                Votes = 14,

                ResourceType = "Library",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            return View(mys);
        }
    }
}