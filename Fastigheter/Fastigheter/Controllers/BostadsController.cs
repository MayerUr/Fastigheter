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
    public class BostadsController : Controller
    {
        private FastigheterContext db = new FastigheterContext();

        // GET: Bostads
        public ActionResult Index()
        {
            return View(db.Bostads.ToList());
        }

        // GET: Bostads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bostad bostad = db.Bostads.Find(id);
            if (bostad == null)
            {
                return HttpNotFound();
            }
            return View(bostad);
        }

        // GET: Bostads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bostads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FastighetId,Nummer")] Bostad bostad)
        {
            if (ModelState.IsValid)
            {
                db.Bostads.Add(bostad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bostad);
        }

        // GET: Bostads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bostad bostad = db.Bostads.Find(id);
            if (bostad == null)
            {
                return HttpNotFound();
            }
            return View(bostad);
        }

        // POST: Bostads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FastighetId,Nummer")] Bostad bostad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bostad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bostad);
        }

        // GET: Bostads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bostad bostad = db.Bostads.Find(id);
            if (bostad == null)
            {
                return HttpNotFound();
            }
            return View(bostad);
        }

        // POST: Bostads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bostad bostad = db.Bostads.Find(id);
            db.Bostads.Remove(bostad);
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
