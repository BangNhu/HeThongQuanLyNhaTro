using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using QuanLyNhaTro_DACSN.Model;
using System.Windows.Data;
using System.ComponentModel;

namespace QuanLyNhaTro_DACSN.ViewModel
{
    class PhongTroViewModel:BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> _KhachTro;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> KhachTro { get => _KhachTro; set { _KhachTro = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> _DICHVU;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> DichVu { get => _DICHVU; set { _DICHVU = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> _SD_DichVu;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> SD_DichVu { get => _SD_DichVu; set { _SD_DichVu = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.DienNuoc> _DienNuoc;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.DienNuoc> DienNuoc { get => _DienNuoc; set { _DienNuoc = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.HOPDONG> _HOPDONG;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.HOPDONG> HOPDONG { get => _HOPDONG; set { _HOPDONG = value; OnPropertyChanged(); } }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.Khutro> _KhuTro;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.Khutro> KhuTro { get => _KhuTro; set { _KhuTro = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private PHONG _SelectedItem;
        public PHONG SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenPhong = SelectedItem.TenPhong;
                    DonGiaPhong = SelectedItem.DonGiaPhong;
                    //SoLgHienTai = (int)SelectedItem.SoLgToiDa;
                    SoLgToiDa = (int)SelectedItem.SoLgToiDa;
                    SelectedKhuTro = SelectedItem.Khutro;
                }

            }
        }
        private Khutro _SelectedKhuTro;
        public Khutro SelectedKhuTro
        {
            get => _SelectedKhuTro; set
            {
                _SelectedKhuTro = value; OnPropertyChanged();
            }
        }
        private String _TenPhong;
        public String TenPhong { get => _TenPhong; set { _TenPhong = value; OnPropertyChanged(); } }
        private int _DonGiaPhong;
        public int DonGiaPhong { get => _DonGiaPhong; set { _DonGiaPhong = value; OnPropertyChanged(); } }
        private int _SoLgToiDa;
        public int SoLgToiDa { get => _SoLgToiDa; set { _SoLgToiDa = value; OnPropertyChanged(); } }
        private int _SoLgHienTai;
       public int SoLgHienTai { get => _SoLgHienTai; set { _SoLgHienTai = value; OnPropertyChanged(); } }
        private bool _TrangThai;
        public bool TrangThai { get => _TrangThai; set { _TrangThai = value; OnPropertyChanged(); } }



        public PhongTroViewModel()
        {
            List = new ObservableCollection<Model.PHONG>(DataProvider.Ins.DB.PHONGs);
            KhuTro = new ObservableCollection<Model.Khutro>(DataProvider.Ins.DB.Khutroes);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedKhuTro==null || TenPhong.Equals(SelectedItem.TenPhong)== true)
                    return false;
                /*var displayList = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong==SelectedItem.MaPhong);
                if (displayList != null || displayList.Count() != 0)
                    return true;*/
                return true ;
            }, (p) => {
                var dv = new PHONG() { TenPhong = TenPhong, DonGiaPhong = DonGiaPhong, SoLgToiDa = SoLgToiDa, MaKhuTro =SelectedKhuTro.MaKhuTro };
                DataProvider.Ins.DB.PHONGs.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedKhuTro==null||SelectedItem==null)
                    return false;
               var displayList = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong == SelectedItem.MaPhong);
                if (displayList != null || displayList.Count() != 0)
                    return true;
               return false;
            }, (p) => {
                var dv = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong == SelectedItem.MaPhong).SingleOrDefault();
                dv.TenPhong = TenPhong;
                dv.DonGiaPhong = DonGiaPhong;
                dv.SoLgToiDa = SoLgToiDa;
                dv.MaKhuTro=SelectedKhuTro.MaKhuTro;
                DataProvider.Ins.DB.SaveChanges();
               
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedKhuTro == null || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong == SelectedItem.MaPhong);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
            var t = MessageBox.Show("Bạn có chắc xóa?", "Nhắc nhở", MessageBoxButton.YesNo);
                if (t == MessageBoxResult.Yes)
                {
                    var PhongTro = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong == SelectedItem.MaPhong).SingleOrDefault();
                    var collection = DataProvider.Ins.DB.HOPDONGs.Where(x => x.MaPhong == SelectedItem.MaPhong).ToList();
                    foreach (var item in collection)
                    {
                        DataProvider.Ins.DB.HOPDONGs.Remove(item);
                        HOPDONG.Remove(item);
                        HOPDONG.Clear();
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    var collection1 = DataProvider.Ins.DB.Khutroes.Where(x => x.MaKhuTro == SelectedItem.MaKhuTro).ToList();
                    foreach (var item in collection1)
                    {
                        DataProvider.Ins.DB.Khutroes.Remove(item);
                        KhuTro.Remove(item);
                        KhuTro.Clear();

                    }
                    DataProvider.Ins.DB.PHONGs.Remove(PhongTro);
                    List.Remove(PhongTro);
                    DataProvider.Ins.DB.SaveChanges();
                    ICollectionView view = CollectionViewSource.GetDefaultView(KhuTro);
                    view.Refresh();
                }
            });
            /* AddCommand = new RelayCommand<object>((p) =>
             {
                 if (string.IsNullOrEmpty(TenPhong) && DonGiaPhong == 0)
                     return false;
                 var displayList = DataProvider.Ins.DB.PHONGs.Where(x => x.TenPhong == TenPhong || x.DonGiaPhong == DonGiaPhong || x.TenKhuTro == SelectedKhuTro.TenKhuTro || x.SoLgToiDa == SoLgToiDa );
                 if (displayList == null || displayList.Count() != 0)
                     return false;
                 return true;
             }, (p) => {
                 var dv = new PHONG() { TenPhong = TenPhong, DonGiaPhong = DonGiaPhong,TenKhuTro = SelectedKhuTro.TenKhuTro ,SoLgToiDa = SoLgToiDa };
                 DataProvider.Ins.DB.PHONGs.Add(dv);
                 DataProvider.Ins.DB.SaveChanges();
                 List.Add(dv);
             });

             EditCommand = new RelayCommand<object>((p) =>
             {
                 if (string.IsNullOrEmpty(TenPhong) && DonGiaPhong == 0 || SelectedItem == null || SelectedKhuTro == null)
                     return false;
                 var displayList = DataProvider.Ins.DB.PHONGs.Where(x => x.TenPhong == TenPhong && x.DonGiaPhong == DonGiaPhong && x.TenKhuTro == SelectedKhuTro.TenKhuTro && x.SoLgToiDa == SoLgToiDa);
                 if (displayList != null || displayList.Count() != 0)
                     return true;
                 return false;
             }, (p) =>
             {
                 var dv = DataProvider.Ins.DB.PHONGs.Where(x => x.MaPhong == SelectedItem.MaPhong).SingleOrDefault();
                 dv.TenPhong = TenPhong;
                 dv.DonGiaPhong = DonGiaPhong;
                 dv.TenKhuTro = SelectedKhuTro.TenKhuTro;
                 dv.SoLgToiDa = SoLgToiDa;
                 DataProvider.Ins.DB.SaveChanges();

                 SelectedItem.TenPhong = TenPhong;
             });*/



        }

    }
}
