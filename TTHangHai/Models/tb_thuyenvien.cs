//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTHangHai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_thuyenvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_thuyenvien()
        {
            this.tb_danhsachthuyenvien = new HashSet<tb_danhsachthuyenvien>();
            this.tb_thuyen = new HashSet<tb_thuyen>();
        }
    
        public int MaThuyenVien { get; set; }
        public string HoTenLot { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string Mobile { get; set; }
        public string SoDienThoai { get; set; }
        public string SoCMND { get; set; }
        public string NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string TaiKhoan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_danhsachthuyenvien> tb_danhsachthuyenvien { get; set; }
        public virtual tb_taikhoan tb_taikhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_thuyen> tb_thuyen { get; set; }
    }
}
