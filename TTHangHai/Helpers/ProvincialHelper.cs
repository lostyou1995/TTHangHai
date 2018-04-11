using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTHangHai
{
    public class ProvincialHelper
    {
        public static MvcHtmlString Provincial(string name, string @class="")
        {
            var tagSelect = new TagBuilder("select");
            tagSelect.Attributes.Add("name", name);
            tagSelect.Attributes.Add("class", "form-control");
            tagSelect.MergeAttribute("class", @class);
            string str = "";
            str += "<option value='An Giang'>An Giang</option>";
            str += "<option value='Bà Rịa - Vũng tàu'>Bà Rịa - Vũng tàu</option>";
            str += "<option value='Bắc Cạn'>Bắc Cạn</option>";
            str += "<option value='Bắc Giang'>Bắc Giang</option>";
            str += "<option value='Bạc Liêu'>Bạc Liêu</option>";
            str += "<option value='Bắc Ninh'>Bắc Ninh</option>";
            str += "<option value='Bến Tre'>Bến Tre</option>";
            str += "<option value='Bình Định'>Bình Định</option>";
            str += "<option value='Bình Dương'>Bình Dương</option>";
            str += "<option value='Bình Phước'>Bình Phước</option>";
            str += "<option value='Bình Thuận'>Bình Thuận</option>";
            str += "<option value='Cà Mau'>Cà Mau</option>";
            str += "<option value='Cần Thơ'>Cần Thơ</option>";
            str += "<option value='Cao Bằng'>Cao Bằng</option>";
            str += "<option value='Đà Nẵng'>Đà Nẵng</option>";
            str += "<option value='Đăk Lăk'>Đăk Lăk</option>";
            str += "<option value='Đăk Nông'>Đăk Nông</option>";
            str += "<option value='Đồng Nai'>Đồng Nai</option>";
            str += "<option value='Đồng Tháp'>Đồng Tháp</option>";
            str += "<option value='Gia Lai'>Gia Lai</option>";
            str += "<option value='Hà Giang'>Hà Giang</option>";
            str += "<option value='Hà Nam'>Hà Nam</option>";
            str += "<option value='Hà Nội'>Hà Nội</option>";
            str += "<option value='Hà Tây'>Hà Tây</option>";
            str += "<option value='Hà Tĩnh'>Hà Tĩnh</option>";
            str += "<option value='Hải Dương'>Hải Dương</option>";
            str += "<option value='Hải Phòng'>Hải Phòng</option>";
            str += "<option value='Hậu Giang'>Hậu Giang</option>";
            str += "<option value='Hòa Bình'>Hòa Bình</option>";
            str += "<option value='Hưng Yên'>Hưng Yên</option>";
            str += "<option value='Khánh Hòa'>Khánh Hòa</option>";
            str += "<option value='Kiên Giang'>Kiên Giang</option>";
            str += "<option value='Kon Tum'>Kon Tum</option>";
            str += "<option value='Lai Châu'>Lai Châu</option>";
            str += "<option value='Lâm Đồng'>Lâm Đồng</option>";
            str += "<option value='Lạng Sơn'>Lạng Sơn</option>";
            str += "<option value='Lào Cai'>Lào Cai</option>";
            str += "<option value='Long An'>Long An</option>";
            str += "<option value='Nam Định'>Nam Định</option>";
            str += "<option value='Nghệ An'>Nghệ An</option>";
            str += "<option value='Ninh Bình'>Ninh Bình</option>";
            str += "<option value='Ninh Thuận'>Ninh Thuận</option>";
            str += "<option value='Phú Thọ'>Phú Thọ</option>";
            str += "<option value='Phú Yên'>Phú Yên</option>";
            str += "<option value='Quảng Bình'>Quảng Bình</option>";
            str += "<option value='Quảng Nam'>Quảng Nam</option>";
            str += "<option value='Quảng Ngãi'>Quảng Ngãi</option>";
            str += "<option value='Quảng Ninh'>Quảng Ninh</option>";
            str += "<option value='Quảng Trị'>Quảng Trị</option>";
            str += "<option value='Sóc Trăng'>Sóc Trăng</option>";
            str += "<option value='Sơn La'>Sơn La</option>";
            str += "<option value='Tây Ninh'>Tây Ninh</option>";
            str += "<option value='Thái Bình'>Thái Bình</option>";
            str += "<option value='Thái Nguyên'>Thái Nguyên</option>";
            str += "<option value='Thanh Hóa'>Thanh Hóa</option>";
            str += "<option value='Thừa Thiên Huế'>Thừa Thiên Huế</option>";
            str += "<option value='Tiền Giang'>Tiền Giang</option>";
            str += "<option value='Tp. Hồ Chí Minh'>Tp. Hồ Chí Minh</option>";
            str += "<option value='Trà Vinh'>Trà Vinh</option>";
            str += "<option value='Tuyên Quang'>Tuyên Quang</option>";
            str += "<option value='Vĩnh Long'>Vĩnh Long</option>";
            str += "<option value='Vĩnh Phúc'>Vĩnh Phúc</option>";
            str += "<option value='Yên Bái'>Yên Bái</option>";
            tagSelect.InnerHtml = str;
            return new MvcHtmlString(tagSelect.ToString());
        }
    }
}