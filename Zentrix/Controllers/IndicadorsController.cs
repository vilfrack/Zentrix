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
    public class IndicadorsController : Controller
    {
        private SAINTPALLEntities1 db = new SAINTPALLEntities1();

        // GET: Indicadors
        public ActionResult Index()
        {
            return View(db.Indicador.ToList());
        }

        // GET: Indicadors/Details/5
        public ActionResult Details(int? id)
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

        // GET: Indicadors/Create
        public ActionResult Create()
        {
            Perpestiva();
            return View();
        }

        // POST: Indicadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDIndicador,nombre,objetivoEstrategico,target,rojo,amarillo,verde,fecha")] ViewIndicadorPerspectiva indicador, string IDPerspectiva)
        {
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
                var IDIndicador = db.Indicador.OrderByDescending(x => x.IDIndicador).Select(s=>s.IDIndicador).First();
                MasterPerspectivaIndicador master = new MasterPerspectivaIndicador();
                master.IDIndicador = IDIndicador;
                master.IDPerspectiva = Convert.ToInt32(IDPerspectiva);
                db.MasterPerspectivaIndicador.Add(master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            Perpestiva();
            return View(indicador);
        }

        // GET: Indicadors/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Indicadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDIndicador,nombre,objetivoEstrategico,target,rojo,amarillo,verde,fecha")] Indicador indicador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indicador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicador);
        }

        // GET: Indicadors/Delete/5
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

        // POST: Indicadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Indicador indicador = db.Indicador.Find(id);
            db.Indicador.Remove(indicador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private void Perpestiva() {
            ViewBag.Perpestiva = new SelectList(db.Perspectiva.ToList(), "IDPerspectiva", "Perspectiva1");
    }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
