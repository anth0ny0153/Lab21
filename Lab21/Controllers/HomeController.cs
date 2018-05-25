using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;
namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SignUpForm()
        {
            return View();
        }
        public ActionResult AddNewUser(UserInfo newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Welcome {newUser.FirstName}";
                return View("Confirm");
            }
            else
            {
                return View("Error");
            }
        }
        public ActionResult Coffee()
        {
            return View();
        }
    }
}