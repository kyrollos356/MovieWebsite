using FormalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormalProject.Controllers
{
    public class AllMoviesController : Controller
    {
        public ActionResult SearchResult(string search)
        {
            Movie movie = new Movie();
           movie.name = (string)TempData["searchContent"];

            return View(movie);
        }
        public ActionResult Search(string searchContent)
        {
            TempData["searchContent"] = searchContent;
            return RedirectToAction("SearchResult", "AllMovies");
        }
    }
}
