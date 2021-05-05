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

namespace QuanLyNhaTro_DACSN.ViewModel
{
    public class HopDongViewModel : BaseViewModel
    {
        public ICommand ChonCommand { get; set; }
        public ICommand BoChonCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.HOPDONG> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.HOPDONG> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> _PHONG;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> _KhachTro;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> KhachTro { get => _KhachTro; set { _KhachTro = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> _DichVu;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> DichVu { get => _DichVu; set { _DichVu = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> _ListDV;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> ListDV { get => _ListDV; set { _ListDV = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> _ServicesByRoom;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> ServicesByRoom { get=> _ServicesByRoom; set { _ServicesByRoom = value; ; OnPropertyChanged(); } }

        private QuanLyNhaTro_DACSN.Model.HOPDONG _SelectedItem;
        public QuanLyNhaTro_DACSN.Model.HOPDONG SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    NgayBatDauHopDong = SelectedItem.NgayBatDauHopDong;
                    NgayKetThucHopDong = SelectedItem.NgayKetThucHopDong;
                    TienDatCoc = SelectedItem.TienDatCoc;
                    SelectedPhong = SelectedItem.PHONG;
                    SelectedKhachTro = SelectedItem.KhachTro;
                }

            }
        }
        private QuanLyNhaTro_DACSN.Model.PHONG _SelectedPhong;
        public QuanLyNhaTro_DACSN.Model.PHONG SelectedPhong
        {
            get => _SelectedPhong; set
            {
                
                _SelectedPhong = value; OnPropertyChanged();
                OnRoomChanged();
            }
        }

        private void OnRoomChanged()
        {
           
           

            var roomId = this.SelectedPhong.MaPhong;
            var services = this.ListDV.Where(n => n.MaPhong == roomId);
            this.ServicesByRoom = new ObservableCollection < QuanLyNhaTro_DACSN.Model.SD_DichVu >(services);
        }

        private QuanLyNhaTro_DACSN.Model.KhachTro _SelectedKhachTro;
        public QuanLyNhaTro_DACSN.Model.KhachTro SelectedKhachTro
        {
            get => _SelectedKhachTro; set
            {
                _SelectedKhachTro = value; OnPropertyChanged();

            }
        }
        private QuanLyNhaTro_DACSN.Model.SD_DichVu _SelectedSD_DichVu;
        public QuanLyNhaTro_DACSN.Model.SD_DichVu SelectedSD_DichVu
        {
            get => _SelectedSD_DichVu; set
            {
                _SelectedSD_DichVu = value; OnPropertyChanged();

            }
        }
        private QuanLyNhaTro_DACSN.Model.DICHVU _SelectedDichVu;
        public QuanLyNhaTro_DACSN.Model.DICHVU SelectedDichVu
        {
            get => _SelectedDichVu; set
            {
                _SelectedDichVu = value; OnPropertyChanged();
                if(SelectedDichVu!=null)
                {
                    TenDV = SelectedDichVu.TenDV;
                }    

            }
        }
        private DateTime _NgayBatDauHopDong;
        public DateTime NgayBatDauHopDong { get => _NgayBatDauHopDong; set { _NgayBatDauHopDong = value; OnPropertyChanged(); } }
        private DateTime _NgayKetThucHopDong;
        public DateTime NgayKetThucHopDong { get => _NgayKetThucHopDong; set { _NgayKetThucHopDong = value; OnPropertyChanged(); } }
        private double _TienDatCoc;
        public double TienDatCoc { get => _TienDatCoc; set { _TienDatCoc = value; OnPropertyChanged(); } }
        private string _TenDV;
        public string TenDV { get => _TenDV; set { _TenDV = value; OnPropertyChanged(); } }
        private int _MaPhong;
        public int MaPhong { get => _MaPhong; set { _MaPhong = value; OnPropertyChanged(); } }
        private string _TenKT;
        public string TenKT { get => _TenKT ; set { _TenKT = value; OnPropertyChanged(); } }
        public HopDongViewModel()
        {
            List = new ObservableCollection<Model.HOPDONG>(DataProvider.Ins.DB.HOPDONGs);
            PHONG = new ObservableCollection<Model.PHONG>(DataProvider.Ins.DB.PHONGs);
            DichVu = new ObservableCollection<Model.DICHVU>(DataProvider.Ins.DB.DICHVUs);
            ListDV = new ObservableCollection<Model.SD_DichVu>(DataProvider.Ins.DB.SD_DichVu);
            
            //Chọn Dịch Vụ
            ChonCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedDichVu == null||SelectedPhong == null||SelectedKhachTro==null)
                    return false;
                if (SelectedDichVu.MaDV == SelectedSD_DichVu.MaDV)
                    return false;

                return true;
            }, (p) => {
                var dv = new QuanLyNhaTro_DACSN.Model.SD_DichVu()
                {
                    MaDV = SelectedDichVu.MaDV,
                    MaPhong = SelectedPhong.MaPhong

                };
                DataProvider.Ins.DB.SD_DichVu.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                ServicesByRoom.Add(dv);
            });
            //Bỏ Chọn Dịch Vụ
            BoChonCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedSD_DichVu == null)
                    return false;
                return true;
            }, (p) => {
                var dv = DataProvider.Ins.DB.SD_DichVu.Where(x => x.MaDV == SelectedSD_DichVu.MaDV && x.MaPhong == SelectedPhong.MaPhong).SingleOrDefault();
                DataProvider.Ins.DB.SD_DichVu.Remove(dv);
                DataProvider.Ins.DB.SaveChanges();
                ServicesByRoom.Remove(dv);
            });

            AddCommand = new RelayCommand<object>((p) =>
            {
                if ( SelectedPhong == null)
                    return false;
                return true;
            }, (p) => {
                var dv = new QuanLyNhaTro_DACSN.Model.HOPDONG() { TienDatCoc = TienDatCoc, NgayBatDauHopDong = NgayBatDauHopDong, NgayKetThucHopDong = NgayKetThucHopDong,MaKT = SelectedKhachTro.MaKT,
                MaPhong = SelectedPhong.MaPhong};
                DataProvider.Ins.DB.HOPDONGs.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedPhong == null /*GioiTinh.Equals("Nữ") != true ||GioiTinh.Equals("Nam")==false*/)
                    return false;
                var displayList = DataProvider.Ins.DB.HOPDONGs.Where(x => x.MaKT == SelectedItem.MaKT);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
                var dv = DataProvider.Ins.DB.HOPDONGs.Where(x => x.MaKT == SelectedItem.MaKT).SingleOrDefault();
                dv.TienDatCoc = TienDatCoc;
                dv.NgayBatDauHopDong = NgayBatDauHopDong;
                dv.NgayKetThucHopDong = NgayKetThucHopDong;
                dv.MaKT = SelectedKhachTro.MaKT;
                dv.MaPhong = SelectedPhong.MaPhong;
                DataProvider.Ins.DB.SaveChanges();
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedPhong == null /*GioiTinh.Equals("Nữ") != true ||GioiTinh.Equals("Nam")==false*/)
                    return false;
                var displayList = DataProvider.Ins.DB.HOPDONGs.Where(x => x.MaKT == SelectedItem.MaKT);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
                var dv = DataProvider.Ins.DB.HOPDONGs.Where(x => x.MaKT == SelectedItem.MaKT).SingleOrDefault();
                DataProvider.Ins.DB.HOPDONGs.Remove(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Remove(dv);
            });
        }

    }
}
