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
        // GET: Radnom
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek" };
            //return new ViewResult();
            //return Content("Hello World");
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
            //return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} / {month}");
        }
    }
}