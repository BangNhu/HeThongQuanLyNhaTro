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
    public class KhachTroViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.KhachTro> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> _PHONG;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }
        private QuanLyNhaTro_DACSN.Model.KhachTro _SelectedItem;
        public QuanLyNhaTro_DACSN.Model.KhachTro SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenKT = SelectedItem.TenKT;
                    CMND = SelectedItem.CMND;
                    SDT = SelectedItem.SDT;
                    MatKhau = SelectedItem.MatKhau;
                    GioiTinh = SelectedItem.GioiTinh;
                    SelectedPhong = SelectedItem.PHONG;
                    NgaySinh = SelectedItem.NgaySinh;
                }

            }
        }
        private QuanLyNhaTro_DACSN.Model.PHONG _SelectedPhong;
        public QuanLyNhaTro_DACSN.Model.PHONG SelectedPhong
        {
            get => _SelectedPhong; set
            {
                _SelectedPhong = value; OnPropertyChanged();
        
            }
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

        public KhachTroViewModel()
        {
            List = new ObservableCollection<Model.KhachTro>(DataProvider.Ins.DB.KhachTroes);
            PHONG = new ObservableCollection<Model.PHONG>(DataProvider.Ins.DB.PHONGs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if ( SelectedPhong == null || string.IsNullOrEmpty(TenKT)|| CMND.Length != 9 || SDT.Length > 10||MatKhau.Length<5)
                    return false;

                var displayList = DataProvider.Ins.DB.KhachTroes.Where(x => x.TenKT == TenKT && x.CMND == CMND && x.SDT == SDT && x.MatKhau == MatKhau && x.GioiTinh == GioiTinh);
                if (displayList == null || displayList.Count() != 0)
                    return false;   
                return true;
            }, (p) => {
                var dv = new QuanLyNhaTro_DACSN.Model.KhachTro() { TenKT = TenKT, CMND = CMND, SDT = SDT, MatKhau = MatKhau, GioiTinh = GioiTinh };
                DataProvider.Ins.DB.KhachTroes.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null ||SelectedPhong == null ||CMND.Length>9||SDT.Length> 10 || MatKhau.Length < 5/*||GioiTinh.Equals("Nữ") != true ||GioiTinh.Equals("Nam")!=true*/)
                    return false;
                var displayList = DataProvider.Ins.DB.KhachTroes.Where(x => x.MaKT == SelectedItem.MaKT);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
                var dv = DataProvider.Ins.DB.KhachTroes.Where(x => x.MaKT == SelectedItem.MaKT).SingleOrDefault();
                dv.TenKT = TenKT;
                dv.NgaySinh = NgaySinh;
                dv.CMND = CMND;
                dv.SDT = SDT;
                dv.MatKhau = MatKhau;
                dv.GioiTinh = GioiTinh;
                dv.MaPhong = SelectedPhong.MaPhong;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.TenKT = TenKT;
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null || SelectedPhong == null /*GioiTinh.Equals("Nữ") != true ||GioiTinh.Equals("Nam")==false*/)
                    return false;
                var displayList = DataProvider.Ins.DB.KhachTroes.Where(x => x.MaKT == SelectedItem.MaKT);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
                var t = MessageBox.Show("Bạn có chắc xóa?", "Nhắc nhở", MessageBoxButton.YesNo);
                if(t == MessageBoxResult.Yes)
                {
                    var dv = DataProvider.Ins.DB.KhachTroes.Where(x => x.MaKT == SelectedItem.MaKT).SingleOrDefault();
                    DataProvider.Ins.DB.KhachTroes.Remove(dv);
                    DataProvider.Ins.DB.SaveChanges();
                    List.Remove(dv);
                }
                
            });

        }

    }
}
