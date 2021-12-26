using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using NewsSiteTest.Models;


namespace NewsSiteTest.Controllers
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

        [HttpPost]
        [AllowAnonymous]
        public ActionResult About(CheckSignIn objUserData)
        {
            DataTable dtUserData = new DataTable();
            CheckSignIn objCreateUser = new CheckSignIn();
            bool sResult;
            sResult = objCreateUser.CreateUser(objUserData);

            if (sResult)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ResultMsg = "Could not create User. Please enter the correct Details";
                return View();
            }

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}