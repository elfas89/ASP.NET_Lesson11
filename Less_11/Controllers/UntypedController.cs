using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Less_11.Controllers
{
    public class UntypedController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name = "noname", int age = 000, string sex = "unsex", bool pet = false, string continent = "unknown continent")
        {
            ViewBag.Info = name + " " + age + " " + sex + " " + pet + " " + continent;

            return View();
        }
    }
}