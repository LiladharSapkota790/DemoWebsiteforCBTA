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
    public class PostDetailsController : Controller
    {
        private DemoWebsiteforCBTAContext db = new DemoWebsiteforCBTAContext();

        // GET: PostDetails
        public ActionResult Index()
        {
            var postDetails = db.PostDetails.Include(p => p.Member).Include(p => p.Post);
            return View(postDetails.ToList());
        }

        // GET: PostDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostDetails postDetails = db.PostDetails.Find(id);
            if (postDetails == null)
            {
                return HttpNotFound();
            }
            return View(postDetails);
        }

        // GET: PostDetails/Create
        public ActionResult Create()
        {
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName");
            ViewBag.PostID = new SelectList(db.Posts, "PostID", "PostTitle");
            return View();
        }

        // POST: PostDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Memberid,PostID")] PostDetails postDetails)
        {
            if (ModelState.IsValid)
            {
                db.PostDetails.Add(postDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", postDetails.Memberid);
            ViewBag.PostID = new SelectList(db.Posts, "PostID", "PostTitle", postDetails.PostID);
            return View(postDetails);
        }

        // GET: PostDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostDetails postDetails = db.PostDetails.Find(id);
            if (postDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", postDetails.Memberid);
            ViewBag.PostID = new SelectList(db.Posts, "PostID", "PostTitle", postDetails.PostID);
            return View(postDetails);
        }

        // POST: PostDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Memberid,PostID")] PostDetails postDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Memberid = new SelectList(db.Members, "Memberid", "MFirstName", postDetails.Memberid);
            ViewBag.PostID = new SelectList(db.Posts, "PostID", "PostTitle", postDetails.PostID);
            return View(postDetails);
        }

        // GET: PostDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostDetails postDetails = db.PostDetails.Find(id);
            if (postDetails == null)
            {
                return HttpNotFound();
            }
            return View(postDetails);
        }

        // POST: PostDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostDetails postDetails = db.PostDetails.Find(id);
            db.PostDetails.Remove(postDetails);
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
