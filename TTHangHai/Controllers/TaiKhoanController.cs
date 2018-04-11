using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TTHangHai.Models;

namespace TTHangHai.Controllers
{
    public class TaiKhoanController : Controller
    {
        // GET: TaiKhoan
        public ActionResult PhuongThucDangKy(string loaidk)
        {
            if (loaidk == null)
                return View();
            if (loaidk.CompareTo("tkcn") == 0)
            {
                return RedirectToAction("DangKyTKCaNhan");
            }
            return View();
        }

        public ActionResult DangKyTKCaNhan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKyTKCaNhan(string email, string password, string password1, string fullname, string sex, string birthday, string provincial, string address, string mobile, string phone, string idcard, string idcardday, string noicap, string Acept)
        {
            List<string> arrMess = new List<string>();
            ViewBag.email = email;
            if (string.IsNullOrEmpty(email))
            {
                arrMess.Add("Email là bắt buộc");
            }
            ViewBag.password = password;
            if (string.IsNullOrEmpty(password))
            {
                arrMess.Add("Mật khẩu là bắt buộc");
            }
            ViewBag.password1 = password1;
            if (string.IsNullOrEmpty(password1))
            {
                arrMess.Add("Nhập lại mật khẩu là bắt buộc");
            }
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(password1) && !password.Equals(password1))
            {
                arrMess.Add("Mật khẩu không giống nhau");
                ViewBag.password = "";
                ViewBag.password1 = "";
            }
            ViewBag.fullname = fullname;
            if (string.IsNullOrEmpty(fullname))
            {
                arrMess.Add("Tên người dùng là bắt buộc");
            }
            if (!string.IsNullOrEmpty(fullname) && fullname.Split(' ').Length < 2)
            {
                arrMess.Add("Mời nhập họ tên đầy đủ");
            }
            ViewBag.sex = sex;
            if (string.IsNullOrEmpty(sex))
            {
                arrMess.Add("Giới tính là bắt buộc");
            }
            ViewBag.provincial = provincial;
            if (string.IsNullOrEmpty(provincial))
            {
                arrMess.Add("Nơi sinh là bắt buộc");
            }
            ViewBag.address = address;
            if (string.IsNullOrEmpty(address))
            {
                arrMess.Add("Địa chỉ thường trú là bắt buộc");
            }
            ViewBag.mobile = mobile;
            if (string.IsNullOrEmpty(mobile))
            {
                arrMess.Add("Điện thoại di động là bắt buộc");
            }
            ViewBag.idcard = idcard;
            if (string.IsNullOrEmpty(idcard))
            {
                arrMess.Add("Số chứng minh là bắt buộc");
            }
            ViewBag.idcardday = idcardday;
            if (string.IsNullOrEmpty(idcardday))
            {
                arrMess.Add("Ngày cấp là bắt buộc");
            }
            ViewBag.noicap = noicap;
            if (string.IsNullOrEmpty(noicap))
            {
                arrMess.Add("Nơi cấp là bắt buộc");
            }

            if (string.IsNullOrEmpty(Acept))
            {
                arrMess.Add("đồng ý với quy định về đăng ký và sử dụng dịch vụ tại trang web này");
            }
            if (arrMess.Count > 0)
            {
                ViewBag.Message = arrMess;
                return View();
            }
            using (var db = new db_thongtinthuyenvienEntities())
            {
                using (var context = db.Database.BeginTransaction())
                {
                    try
                    {
                        var arrTen = fullname.Split(' ');
                        var ten = arrTen[arrTen.Length - 1];
                        var hoten = "";
                        for (int i = 0; i < arrTen.Length - 1; i++)
                        {
                            hoten += arrTen[i] + " ";
                        }
                        tb_thuyenvien tv = new tb_thuyenvien()
                        {
                            HoTenLot = hoten,
                            Ten = ten,
                            GioiTinh = sex,
                            NgaySinh = birthday,
                            NoiSinh = provincial,
                            DiaChiThuongTru = address,
                            Mobile = mobile,
                            SoDienThoai = phone,
                            SoCMND = idcard,
                            NgayCap = idcardday,
                            NoiCap = noicap
                        };

                        db.tb_thuyenvien.Add(tv);
                        System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                        tb_taikhoan tk = new tb_taikhoan()
                        {
                            SDTDangKy = mobile,
                            EmailDangKy = email,
                            MatKhau = MD5Hash.GetMd5Hash(md5,password),
                            TenDangNhap = email,
                            TrangThai = false,
                            TKThuyenVien = true
                        };
                        tk.tb_thuyenvien.Add(tv);
                        db.tb_taikhoan.Add(tk);
                        db.SaveChanges();
                        context.Commit();
                        return RedirectToAction("MessageRegister");
                    }
                    catch {
                        context.Rollback();
                        ViewBag.Message.Add("Email đã được đăng ký!");
                    }
                }
            }
            return View();
        }

        public ActionResult MessageRegister(int type)
        {
            return View(type);
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}