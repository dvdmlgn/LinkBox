using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinkBoxWeb.Models;

namespace LinkBoxWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<my> mys = new List<my>();
            mys.Add(new my()
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

            mys.Add(new my()
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

            mys.Add(new my()
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

            mys.Add(new my()
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

            mys.Add(new my()
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

            mys.Add(new my()
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
