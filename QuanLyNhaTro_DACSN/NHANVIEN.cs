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
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.KhachTroes = new HashSet<KhachTro>();
            this.Khutroes = new HashSet<Khutro>();
        }
    
        public int MaNV { get; set; }
        public string TeNV { get; set; }
        public string MatKhau { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public int MaChuTro { get; set; }
    
        public virtual CHUTRO CHUTRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachTro> KhachTroes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Khutro> Khutroes { get; set; }
    }
}
