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
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
