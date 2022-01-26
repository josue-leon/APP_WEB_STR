using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SignalRWebApp.Models;

namespace SignalRWebApp.Controllers
{
    public class ParqueaderoesController : Controller
    {
        private BD_PARQUEADEROEntities db = new BD_PARQUEADEROEntities();

        // GET: Parqueaderoes
        public ActionResult Index()
        {
            return View(db.Parqueaderoes.ToList());
        }

        // GET: Parqueaderoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parqueadero parqueadero = db.Parqueaderoes.Find(id);
            if (parqueadero == null)
            {
                return HttpNotFound();
            }
            return View(parqueadero);
        }

        // GET: Parqueaderoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parqueaderoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParqueaderoID,Nombre,Direccion,EspaciosTotal,EspaciosOcupados,EspaciosDisponibles")] Parqueadero parqueadero)
        {
            if (ModelState.IsValid)
            {
                db.Parqueaderoes.Add(parqueadero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parqueadero);
        }

        // GET: Parqueaderoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parqueadero parqueadero = db.Parqueaderoes.Find(id);
            if (parqueadero == null)
            {
                return HttpNotFound();
            }
            return View(parqueadero);
        }

        // POST: Parqueaderoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParqueaderoID,Nombre,Direccion,EspaciosTotal,EspaciosOcupados,EspaciosDisponibles")] Parqueadero parqueadero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parqueadero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parqueadero);
        }

        // GET: Parqueaderoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parqueadero parqueadero = db.Parqueaderoes.Find(id);
            if (parqueadero == null)
            {
                return HttpNotFound();
            }
            return View(parqueadero);
        }

        // POST: Parqueaderoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parqueadero parqueadero = db.Parqueaderoes.Find(id);
            db.Parqueaderoes.Remove(parqueadero);
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
