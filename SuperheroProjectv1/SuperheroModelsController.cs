using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuperheroProjectv1.Models;

namespace SuperheroProjectv1
{
    public class SuperheroModelsController : Controller
    {
        private SuperheroProjectv1Context db = new SuperheroProjectv1Context();

        // GET: SuperheroModels
        public ActionResult Index()
        {
            return View(db.SuperheroModels.ToList());
        }

        // GET: SuperheroModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperheroModel superheroModel = db.SuperheroModels.Find(id);
            if (superheroModel == null)
            {
                return HttpNotFound();
            }
            return View(superheroModel);
        }

        // GET: SuperheroModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SuperheroModelId,Power,Backstory,Name")] SuperheroModel superheroModel)
        {
            if (ModelState.IsValid)
            {
                db.SuperheroModels.Add(superheroModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(superheroModel);
        }

        // GET: SuperheroModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperheroModel superheroModel = db.SuperheroModels.Find(id);
            if (superheroModel == null)
            {
                return HttpNotFound();
            }
            return View(superheroModel);
        }

        // POST: SuperheroModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SuperheroModelId,Power,Backstory,Name")] SuperheroModel superheroModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(superheroModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(superheroModel);
        }

        // GET: SuperheroModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperheroModel superheroModel = db.SuperheroModels.Find(id);
            if (superheroModel == null)
            {
                return HttpNotFound();
            }
            return View(superheroModel);
        }

        // POST: SuperheroModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuperheroModel superheroModel = db.SuperheroModels.Find(id);
            db.SuperheroModels.Remove(superheroModel);
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
