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
    using QuanLyNhaTro_DACSN.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class KhachTro:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachTro()
        {
            this.HOPDONGs = new HashSet<HOPDONG>();
        }
        private String _TenKT;
        public String TenKT { get => _TenKT; set { _TenKT = value; OnPropertyChanged(); } }
        private string _CMND;
        public string CMND { get => _CMND; set { _CMND = value; OnPropertyChanged(); } }
        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }
        private string _MatKhau;
        public string MatKhau { get => _MatKhau; set { _MatKhau = value; OnPropertyChanged(); } }
        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        private DateTime _NgaySinh;
        public DateTime NgaySinh { get => _NgaySinh; set { _NgaySinh = value; OnPropertyChanged(); } }
        public int MaKT { get; set; }

        public Nullable<int> MaPhong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
