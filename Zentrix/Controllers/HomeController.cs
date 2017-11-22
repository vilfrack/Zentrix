using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zentrix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty(Session["usuario"] as string))
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
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