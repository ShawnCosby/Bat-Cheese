using BatCheese.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BatCheese.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.ViewBag.TitlePart = Globalized.Home;

            return View();
        }

        public ActionResult About()
        {
            this.ViewBag.TitlePart = Globalized.About;

            return View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.TitlePart = Globalized.Contact;

            return View();
        }
    }
}