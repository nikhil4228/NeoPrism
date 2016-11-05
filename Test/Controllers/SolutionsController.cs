using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class SolutionsController : Controller
    {
        // GET: Solutions
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ItConsulting()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BussinessConsulting()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LifeSciencesComputerValidation()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ApplicationDevelopment()
        {
            return View();
        }
    }
}