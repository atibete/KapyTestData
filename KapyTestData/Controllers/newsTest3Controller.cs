using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KapyTestData.Models;

namespace KapyTestData.Controllers
{
    public class newsTest3Controller : Controller
    {
        private databaseTest1Entities db = new databaseTest1Entities();

        // GET: newsTest3
        public ActionResult Index()
        {
            return View(db.newsTest3.ToList());
        }

       // GET: newsTest3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            newsTest3 newsTest3 = db.newsTest3.Find(id);
            if (newsTest3 == null)
            {
                return HttpNotFound();
            }
            return View(newsTest3);
        }

        // GET: newsTest3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: newsTest3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "newsID,title,newsdate,newstime,source,origURL,description,category")] newsTest3 newsTest3)
        {
            if (ModelState.IsValid)
            {
                db.newsTest3.Add(newsTest3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsTest3);
        }

        // GET: newsTest3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            newsTest3 newsTest3 = db.newsTest3.Find(id);
            if (newsTest3 == null)
            {
                return HttpNotFound();
            }
            return View(newsTest3);
        }

        // POST: newsTest3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "newsID,title,newsdate,newstime,source,origURL,description,category")] newsTest3 newsTest3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsTest3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsTest3);
        }

        // GET: newsTest3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            newsTest3 newsTest3 = db.newsTest3.Find(id);
            if (newsTest3 == null)
            {
                return HttpNotFound();
            }
            return View(newsTest3);
        }

        // POST: newsTest3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            newsTest3 newsTest3 = db.newsTest3.Find(id);
            db.newsTest3.Remove(newsTest3);
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
