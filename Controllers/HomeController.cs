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
            return View("About");
        }

        [HttpPost]        
        public ActionResult About(CheckSignIn objUserData)
        {
            DataTable dtUserData = new DataTable();
            CheckSignIn objCreateUser = new CheckSignIn();
            bool sResult;
            sResult = objCreateUser.CreateUser(objUserData);

            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }

        public ActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SignUp(CheckSignIn objUserData)
        {
            DataTable dtUserData = new DataTable();
            CheckSignIn objCreateUser = new CheckSignIn();
            bool sResult;

           

            if (objUserData.sPassWord == objUserData.sCnfPassWord)
            {
                sResult = objCreateUser.CreateUser(objUserData);

                if (sResult)
                    return RedirectToAction("Index");
                else
                    return View();
            }else
            {
                
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        //List<string> findLanguage()
        //{
        //    string Language = "KN";
        //    if (Language == "KN")
        //    {
        //        _name = "ಪೂರ್ಣ ಹೆಸರು";
        //    }
        //}

    }
}