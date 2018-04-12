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
    public class tb_thuyenController : Controller
    {
        private db_thongtinthuyenvienEntities db = new db_thongtinthuyenvienEntities();

        // GET: tb_thuyen
        public ActionResult Index()
        {
            var tb_thuyen = db.tb_thuyen.Include(t => t.tb_coquan).Include(t => t.tb_loaitau).Include(t => t.tb_thuyenvien);
            return View(tb_thuyen.ToList());
        }

        // GET: tb_thuyen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_thuyen tb_thuyen = db.tb_thuyen.Find(id);
            if (tb_thuyen == null)
            {
                return HttpNotFound();
            }
            return View(tb_thuyen);
        }

        // GET: tb_thuyen/Create
        public ActionResult Create()
        {
            ViewBag.CoQuanPheDuyet = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan");
            ViewBag.LoaiTau = new SelectList(db.tb_loaitau, "LoaiTau", "TenLoai");
            ViewBag.ChuTau = new SelectList(db.tb_thuyenvien, "MaThuyenVien", "HoTenLot");
            return View();
        }

        // POST: tb_thuyen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTau,SoHieu,TenTau,IMO,QuocTich,LoaiTau,TongDungTichMay,TongCSMayChinh,ChuTau,CoQuanPheDuyet,TrangThai")] tb_thuyen tb_thuyen)
        {
            if (ModelState.IsValid)
            {
                db.tb_thuyen.Add(tb_thuyen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoQuanPheDuyet = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_thuyen.CoQuanPheDuyet);
            ViewBag.LoaiTau = new SelectList(db.tb_loaitau, "LoaiTau", "TenLoai", tb_thuyen.LoaiTau);
            ViewBag.ChuTau = new SelectList(db.tb_thuyenvien, "MaThuyenVien", "HoTenLot", tb_thuyen.ChuTau);
            return View(tb_thuyen);
        }

        // GET: tb_thuyen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_thuyen tb_thuyen = db.tb_thuyen.Find(id);
            if (tb_thuyen == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoQuanPheDuyet = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_thuyen.CoQuanPheDuyet);
            ViewBag.LoaiTau = new SelectList(db.tb_loaitau, "LoaiTau", "TenLoai", tb_thuyen.LoaiTau);
            ViewBag.ChuTau = new SelectList(db.tb_thuyenvien, "MaThuyenVien", "HoTenLot", tb_thuyen.ChuTau);
            return View(tb_thuyen);
        }

        // POST: tb_thuyen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTau,SoHieu,TenTau,IMO,QuocTich,LoaiTau,TongDungTichMay,TongCSMayChinh,ChuTau,CoQuanPheDuyet,TrangThai")] tb_thuyen tb_thuyen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_thuyen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoQuanPheDuyet = new SelectList(db.tb_coquan, "MaCoQuan", "TenCoQuan", tb_thuyen.CoQuanPheDuyet);
            ViewBag.LoaiTau = new SelectList(db.tb_loaitau, "LoaiTau", "TenLoai", tb_thuyen.LoaiTau);
            ViewBag.ChuTau = new SelectList(db.tb_thuyenvien, "MaThuyenVien", "HoTenLot", tb_thuyen.ChuTau);
            return View(tb_thuyen);
        }

        // GET: tb_thuyen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_thuyen tb_thuyen = db.tb_thuyen.Find(id);
            if (tb_thuyen == null)
            {
                return HttpNotFound();
            }
            return View(tb_thuyen);
        }

        // POST: tb_thuyen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_thuyen tb_thuyen = db.tb_thuyen.Find(id);
            db.tb_thuyen.Remove(tb_thuyen);
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
