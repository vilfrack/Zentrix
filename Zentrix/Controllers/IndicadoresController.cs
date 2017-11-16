﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            return View();
        }
        [HttpPost]
        public ActionResult Create(ViewIndicadorPerspectiva indicador, string IDPerspectiva)
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
        public ActionResult Edit(Indicador indicador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indicador).State = EntityState.Modified;
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
    }
}