using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TTHangHai
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "thong-tin",
                defaults: new { controller = "Home", action = "About" }
            );
            routes.MapRoute(
                name: "PhuongThuc",
                url: "chon-dang-ky",
                defaults: new { controller = "TaiKhoan", action = "PhuongThucDangKy" }
            );
            routes.MapRoute(
                name: "DKCaNhan",
                url: "dang-ky-ca-nhan",
                defaults: new { controller = "TaiKhoan", action = "DangKyTKCaNhan" }
            );

            routes.MapRoute(
                name: "DangNhap",
                url: "dang-nhap",
                defaults: new { controller = "TaiKhoan", action = "Login" }
            );
            routes.MapRoute(
                name: "DangXuat",
                url: "dang-xuat",
                defaults: new { controller = "TaiKhoan", action = "DangXuat" }
            );
            //router controller thuyen
            routes.MapRoute(
                name: "ThemMoiThuyen",
                url: "thuyen/them-moi",
                defaults: new { controller = "tb_thuyen", action = "Create" }
            );

            routes.MapRoute(
                name: "DanhSachThuyen",
                url: "thuyen/danh-sach",
                defaults: new { controller = "tb_thuyen", action = "Index" }
            );

            routes.MapRoute(
                name: "XoaThuyen",
                url: "thuyen/xoa/{SoHieu}/{TenTau}-{id}",
                defaults: new { controller = "tb_thuyen", action = "Delete", SoHieu = UrlParameter.Optional, id = UrlParameter.Optional, TenTau = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ChinhSuaThuyen",
                url: "thuyen/chinh-sua/{SoHieu}/{TenTau}-{id}",
                defaults: new { controller = "tb_thuyen", action = "Edit", SoHieu = UrlParameter.Optional, id = UrlParameter.Optional, TenTau = UrlParameter.Optional }
            );

            //router controller loai tau
            routes.MapRoute(
               name: "ThemMoiLoaiTau",
               url: "loai-tau/them-moi",
               defaults: new { controller = "tb_loaitau", action = "Create" }
           );

            routes.MapRoute(
                name: "DanhSachLoaiTau",
                url: "loai-tau/danh-sach",
                defaults: new { controller = "tb_loaitau", action = "Index" }
            );

            routes.MapRoute(
                name: "XoaLoaiTau",
                url: "loai-tau/xoa/{LoaiTau}/{TenLoai}-{id}",
                defaults: new { controller = "tb_loaitau", action = "Delete", TenLoai = UrlParameter.Optional, id = UrlParameter.Optional, LoaiTau = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ChinhSuaLoaiTau",
                url: "loai-tau/chinh-sua/{LoaiTau}/{TenLoai}-{id}",
                defaults: new { controller = "tb_loaitau", action = "Edit", TenLoai = UrlParameter.Optional, id = UrlParameter.Optional, LoaiTau = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
