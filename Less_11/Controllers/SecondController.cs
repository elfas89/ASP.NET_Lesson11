using Less_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Less_11.Controllers
{
    public class SecondController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           // User b = new Book { Name = "Война и мир", Author = "Л.Н. Толстой", Price = 100 };
            return View();
        }

        [HttpPost]
        public string Index(User user)
        {
            return user.ToString();
        }

    }
}