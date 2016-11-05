using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class CarrersController : Controller
    {
        // GET: Carrers
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TrainingProgram()
        {
            return View();
        }
        [HttpGet]
        public ActionResult WhatWeOffer()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EmployeeReferal()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CurrentOpenings()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LabourConditionApplication()
        {
            return View();
        }
    }
}