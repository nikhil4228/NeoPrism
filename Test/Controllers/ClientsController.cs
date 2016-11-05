using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurClients()
        {
            return View();
        }
        public ActionResult OurPartners()
        {
            return View();
        }
    }
}