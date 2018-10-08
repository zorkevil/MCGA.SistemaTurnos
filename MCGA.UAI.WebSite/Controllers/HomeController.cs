using MCGA.UI.WebSite.Constants.HomeController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCGA.UI.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("", Name = HomeControllerRoute.GetIndex)]
        public ActionResult Index()
        {
            ViewBag.CarouselShow = true;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}