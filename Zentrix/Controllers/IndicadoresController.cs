using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zentrix.Models.BD;

namespace Zentrix.Controllers
{
    public class IndicadoresController : Controller
    {
        private BDEntities db = new BDEntities();
        // GET: Indicadores
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DetailFincanciera() {
            return PartialView(db.Indicador.ToList());
        }
        public ActionResult DetailCliente()
        {
            return PartialView(db.Indicador.ToList());
        }
        public ActionResult DetailInterna()
        {
            return PartialView(db.Indicador.ToList());
        }
        public ActionResult DetailAprendizaje()
        {
            return PartialView(db.Indicador.ToList());
        }
    }
}