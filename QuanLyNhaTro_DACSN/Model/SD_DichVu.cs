//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaTro_DACSN.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SD_DichVu
    {
        public int MaPhong { get; set; }
        public int MaDV { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DICHVU DICHVU { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
