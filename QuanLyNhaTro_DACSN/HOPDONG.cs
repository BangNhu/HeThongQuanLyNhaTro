//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaTro_DACSN
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONG
    {
        public int MaHopDong { get; set; }
        public Nullable<int> MaPhong { get; set; }
        public System.DateTime NgayBatDauHopDong { get; set; }
        public System.DateTime NgayKetThucHopDong { get; set; }
        public Nullable<int> MaKT { get; set; }
        public double TienDatCoc { get; set; }
    
        public virtual KhachTro KhachTro { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
