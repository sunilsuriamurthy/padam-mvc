using Padam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padam.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie> { new Movie { ID = 1, Name = "Shrek" }, new Movie { ID = 2, Name = "Commando" } };

            return View("MoviesList", movies);
        }
    }
}