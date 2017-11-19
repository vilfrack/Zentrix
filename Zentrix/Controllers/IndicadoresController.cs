using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zentrix.Helper;
using Zentrix.Models.BD;
using Zentrix.ViewModel;

namespace Zentrix.Controllers
{
    public class IndicadoresController : Controller
    {
        private SAINTPALLEntities1 db = new SAINTPALLEntities1();
        private Helper.Helper help = new Helper.Helper();
        // GET: Indicadores
        public ActionResult Index()
        {
            return View();
        }
        /*
         1 Financiera
         2 Interna
         3 Clientes
         4 Aprendizaje
        */
        #region DETAILS
        public ActionResult DetailFincanciera()
        {
            return PartialView(db.Indicador.Where(w=>w.IDPerspectiva==1).ToList());
        }
        public ActionResult DetailCliente()
        {
            return PartialView(db.Indicador.Where(w => w.IDPerspectiva == 3).ToList());
        }
        public ActionResult DetailInterna()
        {
            return PartialView(db.Indicador.Where(w => w.IDPerspectiva == 2).ToList());
        }
        public ActionResult DetailAprendizaje()
        {
            return PartialView(db.Indicador.Where(w => w.IDPerspectiva == 4).ToList());
        }
        #endregion

        public ActionResult Create()
        {
            Perpestiva();
            marca();
            return View();
        }
        [HttpPost]
        public ActionResult Create(ViewIndicadorPerspectiva indicador, string IDPerspectiva, string DropProducto)
        {
            if (ModelState.IsValid)
            {
                string anio = "2016";
                string mes = indicador.fecha.Split('/').First();
                string periodo = anio + mes;
                Indicador ind = new Indicador();
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = periodo;
                ind.CodItem = DropProducto;
                switch (IDPerspectiva)
                {
                    case "1":
                        ind.conseguido = help.GetResult(periodo, DropProducto);
                        break;
                    case "2":
                        break;
                    case "3":
                        List<ClientesDuplicados> lista = new List<ClientesDuplicados>();
                        lista.AddRange(help.clienteDuplicadoMes(DropProducto, periodo));
                        ind.conseguido = lista.Count;
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }

                ind.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.Indicador.Add(ind);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }

        public ActionResult Edit(int? id)
        {
            Perpestiva();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicador indicador = db.Indicador.Find(id);
            if (indicador == null)
            {
                return HttpNotFound();
            }
            return View(indicador);
        }

        [HttpPost]
        public ActionResult Edit(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
            if (ModelState.IsValid)
            {
                string anio = indicador.fecha.Split('/').Last();
                string mes = indicador.fecha.Split('/').First();
                string periodo = anio + mes;
                var ind = db.Indicador.Find(indicador.IDIndicador);
                ind.nombre = indicador.nombre;
                ind.objetivoEstrategico = indicador.objetivoEstrategico;
                ind.target = indicador.target;
                ind.rojo = indicador.rojo;
                ind.amarillo = indicador.amarillo;
                ind.verde = indicador.verde;
                ind.fecha = indicador.fecha;
                ind.conseguido = help.GetResult(periodo,"");
                ind.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicador indicador = db.Indicador.Find(id);
            if (indicador == null)
            {
                return HttpNotFound();
            }
            return View(indicador);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Indicador indicador = db.Indicador.Find(id);
            db.Indicador.Remove(indicador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        private void Perpestiva()
        {
            ViewBag.Perpestiva = new SelectList(db.Perspectiva.ToList(), "IDPerspectiva", "Perspectiva1");
        }
        public void marca() {
            ViewBag.Marca = new SelectList(db.Proveedor.ToList(), "Proveedor1", "Marca");

        }
        public void producto(string marca) {
            switch (marca)
            {
                case "MAGIC":
                    ViewBag.Producto = new SelectList(db.SAPROD.Where(w => w.CodProd == "MGY005" || w.CodProd == "MGY006")
                                                            .Select(s=>s.Descrip).Distinct().ToList(), "CodProd", "Descrip");
                    break;
                case "GRAFFITI":
                    ViewBag.Producto = new SelectList(db.SAPROD.Where(w => w.CodProd == "GRF0002" || w.CodProd == "GRF0044" || w.CodProd == "GRF0049" || w.CodProd == "GRF0006")
                                                               .Select(s => s.Descrip).Distinct().ToList(), "CodProd", "Descrip");
                    break;
                case "3M":
                    ViewBag.Producto = new SelectList(db.SAPROD.Where(w => w.CodProd == "3M001" || w.CodProd == "3M008" || w.CodProd == "3M007" || w.CodProd == "3M006")
                                                                .Select(s => s.Descrip).Distinct().ToList(), "CodProd", "Descrip");
                    break;
            }
            //MARCA MAGIC
            //MGY005
            //MGY006

            //GRAFFITI - INVERSIONES SIMBI, C.A
            //GRF0003	BARRA SILICON 8 MM X 30 CM P/PISTOLA
            //GRF0007	SILIPEX TUBO NEGRO 70ml
            //GRF0041	BARRA SILICON 8 MM X 20 CM P/PISTOLA
            //GRF0002   BARRA SILICON 11 MM X 15 CM P/ PISTOLA

            //3M - 3M MANUFACTURERA VENEZUELA, C.A.
            //3M016	3M LIJA DE AGUA IMPERIAL 401Q GRANO 2000
            //3M008	LIJA DE AGUA GRANO 280
            //3M022   3M FIBRODISCOS GRANO 36
            //3M021   3M FIBRODISCOS GRANO 24
        }

        public JsonResult GetProdutos(string id)
        {
            List<SelectListItem> states = new List<SelectListItem>();
            switch (id)
            {
                case "MAGIC":
                    var MONTANA = db.SAPROD.Where(w => w.CodProd == "MGY005" || w.CodProd == "MGY006")
                                                            .Select(s => new { Descrip = s.Descrip, CodProd=s.CodProd } ).ToList();
                    foreach (var item in MONTANA)
                    {
                        states.Add(new SelectListItem { Text = item.Descrip, Value = item.CodProd });
                    }
                    break;
                case "GRAFFITI":
                    var GRAFFITI = db.SAPROD.Where(w => w.CodProd == "GRF0002" || w.CodProd == "GRF0044" || w.CodProd == "GRF0049" || w.CodProd == "GRF0006")
                                                               .Select(s => new { Descrip = s.Descrip, CodProd = s.CodProd }).ToList();
                    foreach (var item in GRAFFITI)
                    {
                        states.Add(new SelectListItem { Text = item.Descrip, Value = item.CodProd });
                    }
                    break;
                case "3M":
                    var m = db.SAPROD.Where(w => w.CodProd == "3M001" || w.CodProd == "3M008" || w.CodProd == "3M007" || w.CodProd == "3M006")
                                                                 .Select(s => new { Descrip = s.Descrip, CodProd = s.CodProd }).ToList();
                    foreach (var item in m)
                    {
                        states.Add(new SelectListItem { Text = item.Descrip, Value = item.CodProd });
                    }
                    break;
            }
            return Json(new SelectList(states, "Value", "Text"));
        }

    }
}