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
    
    public partial class tb_danhsachthuyenvien
    {
        public int Tau { get; set; }
        public int ThuyenVien { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public System.DateTime ThoiGian { get; set; }
    
        public virtual tb_thuyen tb_thuyen { get; set; }
        public virtual tb_thuyenvien tb_thuyenvien { get; set; }
    }
}
