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
    
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            this.DienNuocs = new HashSet<DienNuoc>();
            this.HoaDons = new HashSet<HoaDon>();
            this.HOPDONGs = new HashSet<HOPDONG>();
        }
    
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int DonGiaPhong { get; set; }
        public Nullable<int> SoLgToiDa { get; set; }
        public Nullable<int> SoLgHienTai { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> MaKhuTro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DienNuoc> DienNuocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        public virtual Khutro Khutro { get; set; }
    }
}
