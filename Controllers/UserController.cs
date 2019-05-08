using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormalProject.Models;
namespace FormalProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult SignUp()
        {


            return View(); ;
        }
        public ActionResult DisplayInfo(string name,string password)
        {
            User user = new User { name = name,password = password};
            return View(user);
        }
        public ActionResult Login()
        {

            return View() ; 
        }
        public ActionResult LoggedIn()
        {
            return View();
        }
        public ActionResult Search(string searchContent)
        {
            TempData["searchContent"] = searchContent;
            return RedirectToAction("SearchResult", "AllMovies");
        }
    }
}