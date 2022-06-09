using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Radnom
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.ID == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} / {month}");
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {    new Movie{ ID = 1, Name = "Shrek"},
                 new Movie{ ID = 2, Name = "Avengers"}
            };
        }
    }
}