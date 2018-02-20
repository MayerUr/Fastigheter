using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fastigheter.Models;

namespace Fastigheter.Controllers
{
    public class FastighetsController : Controller
    {
        private FastigheterContext db = new FastigheterContext();

        // GET: Fastighets
        public ActionResult Index()
        {
            return View(db.Fastighets.ToList());
        }

        // GET: Fastighets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fastighet fastighet = db.Fastighets.Find(id);
            if (fastighet == null)
            {
                return HttpNotFound();
            }
            return View(fastighet);
        }

        // GET: Fastighets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fastighets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Land,Gatuadress,Postnummer,Postort")] Fastighet fastighet)
        {
            if (ModelState.IsValid)
            {
                db.Fastighets.Add(fastighet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fastighet);
        }

        // GET: Fastighets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fastighet fastighet = db.Fastighets.Find(id);
            if (fastighet == null)
            {
                return HttpNotFound();
            }
            return View(fastighet);
        }

        // POST: Fastighets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Land,Gatuadress,Postnummer,Postort")] Fastighet fastighet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fastighet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fastighet);
        }

        // GET: Fastighets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fastighet fastighet = db.Fastighets.Find(id);
            if (fastighet == null)
            {
                return HttpNotFound();
            }
            return View(fastighet);
        }

        // POST: Fastighets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fastighet fastighet = db.Fastighets.Find(id);
            db.Fastighets.Remove(fastighet);
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
