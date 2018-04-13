using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TTHangHai.Models;

namespace TTHangHai.Controllers
{
    public class tb_loaitauController : Controller
    {
        private db_thongtinthuyenvienEntities db = new db_thongtinthuyenvienEntities();

        // GET: tb_loaitau
        public ActionResult Index()
        {
            var tb_loaitau = db.tb_loaitau.Include(t => t.tb_coquan);
            return View(tb_loaitau.ToList());
        }

        // GET: tb_loaitau/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_loaitau tb_loaitau = db.tb_loaitau.Find(id);
            if (tb_loaitau == null)
            {
                return HttpNotFound();
            }
            return View(tb_loaitau);
        }

        // GET: tb_loaitau/Create
        public ActionResult Create()
        {
            ViewBag.CoQuanThem = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan");
            return View();
        }

        // POST: tb_loaitau/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiTau,TenLoai,TrangThai,CoQuanThem")] tb_loaitau tb_loaitau)
        {
            if (ModelState.IsValid)
            {
                db.tb_loaitau.Add(tb_loaitau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoQuanThem = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_loaitau.CoQuanThem);
            return View(tb_loaitau);
        }

        // GET: tb_loaitau/Edit/5
        public ActionResult Edit(int? id, string LoaiTau, string TenLoai)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_loaitau tb_loaitau = db.tb_loaitau.Find(id);
            if (tb_loaitau == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoQuanThem = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_loaitau.CoQuanThem);
            return View(tb_loaitau);
        }

        // POST: tb_loaitau/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoaiTau,TenLoai,TrangThai,CoQuanThem")] tb_loaitau tb_loaitau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_loaitau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoQuanThem = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_loaitau.CoQuanThem);
            return View(tb_loaitau);
        }

        // GET: tb_loaitau/Delete/5
        public ActionResult Delete(int? id, string LoaiTau, string TenLoai)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_loaitau tb_loaitau = db.tb_loaitau.Find(id);
            if (tb_loaitau == null)
            {
                return HttpNotFound();
            }
            return View(tb_loaitau);
        }

        // POST: tb_loaitau/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_loaitau tb_loaitau = db.tb_loaitau.Find(id);
            db.tb_loaitau.Remove(tb_loaitau);
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
