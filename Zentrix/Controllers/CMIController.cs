using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zentrix.ViewModel;
using Zentrix.Models.BD;

namespace Zentrix.Controllers
{
    public class CMIController : Controller
    {

        private SAINTPALLEntities1 db = new SAINTPALLEntities1();
        public ActionResult Index()
        {

            return View(db.Indicador.ToList());
        }
    }
}