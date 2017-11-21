using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zentrix.Models.BD;

namespace Zentrix.Controllers
{
    public class FinancieraChartController : Controller
    {
        private SAINTPALLEntities1 db = new SAINTPALLEntities1();
        // GET: FinancieraChart
        public ActionResult IndicadorFinanciera()
        {
            return View(db.Indicador.Where(w=>w.IDPerspectiva==1).ToList());
        }
        public ActionResult IndicadorCliente()
        {
            return View(db.Indicador.Where(w => w.IDPerspectiva == 3).ToList());
        }
        public ActionResult IndicadorInterno()
        {
            return View(db.Indicador.Where(w => w.IDPerspectiva == 2).ToList());
        }
    }
}