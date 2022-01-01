using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using NewsSiteTest.Models;

namespace NewsSiteTest.Controllers
{
    public class CoverPageController:Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}