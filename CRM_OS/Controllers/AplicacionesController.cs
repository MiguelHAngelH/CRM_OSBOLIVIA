using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRM_OS.Models;

namespace CRM_OS.Controllers
{
    public class AplicacionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Aplicaciones
        public ActionResult Index()
        {
            var aplicacion = db.Aplicacion.Include(a => a.Modulo);
            return View(aplicacion.ToList());
        }

        // GET: Aplicaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplicacion aplicacion = db.Aplicacion.Find(id);
            if (aplicacion == null)
            {
                return HttpNotFound();
            }
            return View(aplicacion);
        }

        // GET: Aplicaciones/Create
        public ActionResult Create()
        {
            ViewBag.idModulo = new SelectList(db.Modulo, "idModulo", "nombre");
            return View();
        }

        // POST: Aplicaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAplicacion,nombre,idModulo")] Aplicacion aplicacion)
        {
            if (ModelState.IsValid)
            {
                db.Aplicacion.Add(aplicacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idModulo = new SelectList(db.Modulo, "idModulo", "nombre", aplicacion.idModulo);
            return View(aplicacion);
        }

        // GET: Aplicaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplicacion aplicacion = db.Aplicacion.Find(id);
            if (aplicacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idModulo = new SelectList(db.Modulo, "idModulo", "nombre", aplicacion.idModulo);
            return View(aplicacion);
        }

        // POST: Aplicaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAplicacion,nombre,idModulo")] Aplicacion aplicacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aplicacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idModulo = new SelectList(db.Modulo, "idModulo", "nombre", aplicacion.idModulo);
            return View(aplicacion);
        }

        // GET: Aplicaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aplicacion aplicacion = db.Aplicacion.Find(id);
            if (aplicacion == null)
            {
                return HttpNotFound();
            }
            return View(aplicacion);
        }

        // POST: Aplicaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aplicacion aplicacion = db.Aplicacion.Find(id);
            db.Aplicacion.Remove(aplicacion);
            db.SaveChanges();
            return RedirectToAction("Index");
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
