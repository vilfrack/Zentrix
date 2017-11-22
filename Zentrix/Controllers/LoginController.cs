using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zentrix.Models.BD;

namespace Zentrix.Controllers
{
    public class LoginController : Controller
    {
        private SAINTPALLEntities1 db = new SAINTPALLEntities1();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Proplogin lo)
        {
            var usuario = db.Usuario.Where(w => w.login == lo.login).SingleOrDefault();
            if (usuario != null)
            {
                Session["usuario"] = "true";
                Session["NombreUsuario"] = usuario.apellido + " " + usuario.nombre;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.NoExiste = "1";
            }

            return View();
        }
        public ActionResult Logout() {
            Session.RemoveAll();
            return RedirectToAction("Login", "Login");
        }
    }
    public class Proplogin{
        public string login { get; set; }
        public string password { get; set; }
    }
}