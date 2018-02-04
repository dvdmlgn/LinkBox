using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinkBoxWeb.Controllers
{
    public class myController : Controller
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

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new my()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });

            mys.Add(new my()
            {
                Subject = "Maths",
                Topic = "Algebra",
                Chapter = "Quadratic Equations",

                Description = "mathssss",

                Content = "https://startbootstrap.com/template-categories/landing-pages/"
            });


            return View(mys);
        }
    }
}
