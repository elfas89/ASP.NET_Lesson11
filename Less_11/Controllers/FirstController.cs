using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Less_11.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index(int min = 11, int max = 22)
        {
            List<int> list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                list.Add(i);
            }

            ViewBag.Res = list;
            //return View();
            return View(list);
        }
    }
}