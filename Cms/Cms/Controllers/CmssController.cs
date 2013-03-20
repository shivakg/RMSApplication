using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cmsd.Models;

namespace Cmsd.Controllers
{
    public class CmssController : Controller
    {
        private CmsDBContext db = new CmsDBContext();

        //
        // GET: /Cmss/

        public ActionResult Index()
        {
            return View(db.Cmss.ToList());
        }

        //
        // GET: /Cmss/Details/5

        public ActionResult Details(int id = 0)
        {
            Cms cms = db.Cmss.Find(id);
            if (cms == null)
            {
                return HttpNotFound();
            }
            return View(cms);
        }

        //
        // GET: /Cmss/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cmss/Create

        [HttpPost]
        public ActionResult Create(Cmsd cms)
        {
            if (ModelState.IsValid)
            {
                db.Cmss.Add(cms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cms);
        }

        //
        // GET: /Cmss/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cms cms = db.Cmss.Find(id);
            if (cms == null)
            {
                return HttpNotFound();
            }
            return View(cms);
        }

        //
        // POST: /Cmss/Edit/5

        [HttpPost]
        public ActionResult Edit(Cmsd cms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cms);
        }

        //
        // GET: /Cmss/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cms cms = db.Cmss.Find(id);
            if (cms == null)
            {
                return HttpNotFound();
            }
            return View(cms);
        }

        //
        // POST: /Cmss/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cms cms = db.Cmss.Find(id);
            db.Cmss.Remove(cms);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}