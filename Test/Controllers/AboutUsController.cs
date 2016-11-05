using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CompanyOverview()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MissionVision()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Values()
        {
            return View();
        }
    }
}