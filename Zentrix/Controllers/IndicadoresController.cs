using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zentrix.Models.BD;
using Zentrix.ViewModel;

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
        #region DETAILS
        public ActionResult DetailFincanciera()
        {
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
        #endregion
        #region CREATE GET
        public ActionResult CreateFincanciera()
        {
            return View();
        }
        public ActionResult CreateCliente()
        {
            return View();
        }
        public ActionResult CreateInterna()
        {
            return View();
        }
        public ActionResult CreateAprendizaje()
        {
            return View();
        }
        #endregion
        #region CREATE POST
        [HttpPost]
        public ActionResult CreateFincanciera(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
            //IDPerspectiva = 1 Financiera
            IDPerspectiva = "1";
            if (ModelState.IsValid)
            {
                Indicador ind = new Indicador();
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = indicador.fecha;
                ind.conseguido = 8000;
                db.Indicador.Add(ind);
                db.SaveChanges();
                //MasterPerspectivaIndicador
                var IDIndicador = db.Indicador.OrderByDescending(x => x.IDIndicador).Select(s => s.IDIndicador).First();
                MasterPerspectivaIndicador master = new MasterPerspectivaIndicador();
                master.IDIndicador = IDIndicador;
                master.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.MasterPerspectivaIndicador.Add(master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }
        [HttpPost]
        public ActionResult CreateCliente(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
            //IDPerspectiva = 3 Clientes
            IDPerspectiva = "3";
            if (ModelState.IsValid)
            {
                Indicador ind = new Indicador();
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = indicador.fecha;
                ind.conseguido = 8000;
                db.Indicador.Add(ind);
                db.SaveChanges();
                //MasterPerspectivaIndicador
                var IDIndicador = db.Indicador.OrderByDescending(x => x.IDIndicador).Select(s => s.IDIndicador).First();
                MasterPerspectivaIndicador master = new MasterPerspectivaIndicador();
                master.IDIndicador = IDIndicador;
                master.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.MasterPerspectivaIndicador.Add(master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }
        [HttpPost]
        public ActionResult CreateInterna(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
            //IDPerspectiva = 2 Interna
            IDPerspectiva = "2";
            if (ModelState.IsValid)
            {
                Indicador ind = new Indicador();
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = indicador.fecha;
                ind.conseguido = 8000;
                db.Indicador.Add(ind);
                db.SaveChanges();
                //MasterPerspectivaIndicador
                var IDIndicador = db.Indicador.OrderByDescending(x => x.IDIndicador).Select(s => s.IDIndicador).First();
                MasterPerspectivaIndicador master = new MasterPerspectivaIndicador();
                master.IDIndicador = IDIndicador;
                master.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.MasterPerspectivaIndicador.Add(master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }
        [HttpPost]
        public ActionResult CreateAprendizaje(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
            //IDPerspectiva = 4 Aprendizaje
            IDPerspectiva = "4";
            if (ModelState.IsValid)
            {
                Indicador ind = new Indicador();
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = indicador.fecha;
                ind.conseguido = 8000;
                db.Indicador.Add(ind);
                db.SaveChanges();
                //MasterPerspectivaIndicador
                var IDIndicador = db.Indicador.OrderByDescending(x => x.IDIndicador).Select(s => s.IDIndicador).First();
                MasterPerspectivaIndicador master = new MasterPerspectivaIndicador();
                master.IDIndicador = IDIndicador;
                master.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.MasterPerspectivaIndicador.Add(master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }
        #endregion
    }
}