using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek!" };
            return View(movie);

            
            //return Content("Hello World");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home",new { page=1,sortBy="name"});
        }
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

                return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            }
        
    }
}