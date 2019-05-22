using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLharjoitusMVC.Controllers
{
    public class MyWebSiteController : Controller
    {
        // GET: Harjoitus1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View();
        }

        public ActionResult Time()
        {
            return View();
        }
    }
}