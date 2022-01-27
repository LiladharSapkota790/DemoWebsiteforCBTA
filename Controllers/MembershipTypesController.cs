using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoWebsiteforCBTA.Data;
using DemoWebsiteforCBTA.Models;

namespace DemoWebsiteforCBTA.Controllers
{
    public class MembershipTypesController : Controller
    {
        private DemoWebsiteforCBTAContext db = new DemoWebsiteforCBTAContext();

        // GET: MembershipTypes
        public ActionResult Index()
        {
            return View(db.MembershipTypes.ToList());
        }

        // GET: MembershipTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MembershipTypes membershipTypes = db.MembershipTypes.Find(id);
            if (membershipTypes == null)
            {
                return HttpNotFound();
            }
            return View(membershipTypes);
        }

        // GET: MembershipTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembershipTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MembershipTypesId,Names,Price")] MembershipTypes membershipTypes)
        {
            if (ModelState.IsValid)
            {
                db.MembershipTypes.Add(membershipTypes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(membershipTypes);
        }

        // GET: MembershipTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MembershipTypes membershipTypes = db.MembershipTypes.Find(id);
            if (membershipTypes == null)
            {
                return HttpNotFound();
            }
            return View(membershipTypes);
        }

        // POST: MembershipTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MembershipTypesId,Names,Price")] MembershipTypes membershipTypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(membershipTypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(membershipTypes);
        }

        // GET: MembershipTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MembershipTypes membershipTypes = db.MembershipTypes.Find(id);
            if (membershipTypes == null)
            {
                return HttpNotFound();
            }
            return View(membershipTypes);
        }

        // POST: MembershipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MembershipTypes membershipTypes = db.MembershipTypes.Find(id);
            db.MembershipTypes.Remove(membershipTypes);
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
