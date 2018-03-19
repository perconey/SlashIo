using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SlashIo.DAL;
using SlashIo.Models;

namespace SlashIo.Controllers
{
    public class PageDetailsController : Controller
    {
        private OgPropertySetContext db = new OgPropertySetContext();

        // GET: PageDetails
        public ActionResult Index()
        {
            return View(db.PageDetails.ToList());
        }

        // GET: PageDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageDetails pageDetails = db.PageDetails.Find(id);
            if (pageDetails == null)
            {
                return HttpNotFound();
            }
            return View(pageDetails);
        }

        // GET: PageDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PageDetails/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pagedetailsid,CurrentPrefix,ImagesAreUrlProvided")] PageDetails pageDetails)
        {
            if (ModelState.IsValid)
            {
                db.PageDetails.Add(pageDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pageDetails);
        }

        // GET: PageDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageDetails pageDetails = db.PageDetails.Find(id);
            if (pageDetails == null)
            {
                return HttpNotFound();
            }
            return View(pageDetails);
        }

        // POST: PageDetails/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pagedetailsid,CurrentPrefix,ImagesAreUrlProvided")] PageDetails pageDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pageDetails);
        }

        // GET: PageDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageDetails pageDetails = db.PageDetails.Find(id);
            if (pageDetails == null)
            {
                return HttpNotFound();
            }
            return View(pageDetails);
        }

        // POST: PageDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PageDetails pageDetails = db.PageDetails.Find(id);
            db.PageDetails.Remove(pageDetails);
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
