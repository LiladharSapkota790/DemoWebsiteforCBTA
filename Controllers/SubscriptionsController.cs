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
    public class SubscriptionsController : Controller
    {
        private DemoWebsiteforCBTAContext db = new DemoWebsiteforCBTAContext();

        // GET: Subscriptions
        public ActionResult Index()
        {
            var subscriptions = db.Subscriptions.Include(s => s.Member).Include(s => s.MembershipTypes);
            return View(subscriptions.ToList());
        }

        // GET: Subscriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // GET: Subscriptions/Create
        public ActionResult Create()
        {
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName");
            ViewBag.MembershipTypesId = new SelectList(db.MembershipTypes, "MembershipTypesId", "Names");
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MembershipTypesId,Memberid,SubscriptionId,JoinedDate,CanceldDate,Has_paid")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                db.Subscriptions.Add(subscription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", subscription.Memberid);
            ViewBag.MembershipTypesId = new SelectList(db.MembershipTypes, "MembershipTypesId", "Names", subscription.MembershipTypesId);
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", subscription.Memberid);
            ViewBag.MembershipTypesId = new SelectList(db.MembershipTypes, "MembershipTypesId", "Names", subscription.MembershipTypesId);
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MembershipTypesId,Memberid,SubscriptionId,JoinedDate,CanceldDate,Has_paid")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subscription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", subscription.Memberid);
            ViewBag.MembershipTypesId = new SelectList(db.MembershipTypes, "MembershipTypesId", "Names", subscription.MembershipTypesId);
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subscription subscription = db.Subscriptions.Find(id);
            db.Subscriptions.Remove(subscription);
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
