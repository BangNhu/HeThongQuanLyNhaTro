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
    
    public partial class DICHVU:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            this.SD_DichVu = new HashSet<SD_DichVu>();
        }
    
        public int MaDV { get; set; }
        private String _TenDV;
        public String TenDV { get => _TenDV; set { _TenDV = value; OnPropertyChanged(); } }
        private double _DonGia;
        public double DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SD_DichVu> SD_DichVu { get; set; }
    }
}
