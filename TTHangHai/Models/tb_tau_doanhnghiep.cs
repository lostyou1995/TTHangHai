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
    
    public partial class tb_tau_doanhnghiep
    {
        public int Tau { get; set; }
        public string DoanhNghiep { get; set; }
        public Nullable<int> CoQuanPheDuyet { get; set; }
        public string NgayDuyet { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual tb_coquan tb_coquan { get; set; }
        public virtual tb_doanhnghiep tb_doanhnghiep { get; set; }
        public virtual tb_thuyen tb_thuyen { get; set; }
    }
}
