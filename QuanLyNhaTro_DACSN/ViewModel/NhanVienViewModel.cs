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
    class NhanVienViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.NHANVIEN> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.NHANVIEN> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private NHANVIEN _SelectedItem;
        public NHANVIEN SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TeNV = SelectedItem.TeNV;
                    CMND =SelectedItem.CMND;
                    SDT = SelectedItem.SDT;
                    MatKhau = SelectedItem.MatKhau;
                    GioiTinh = SelectedItem.GioiTinh;
                }

            }
        }
        private String _TeNV;
        public String TeNV { get => _TeNV; set { _TeNV = value; OnPropertyChanged(); } }
        private string _CMND;
        public string CMND { get => _CMND; set { _CMND = value; OnPropertyChanged(); } }
        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }
        private string _MatKhau;
        public string MatKhau { get => _MatKhau; set { _MatKhau = value; OnPropertyChanged(); } }
        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }

        public NhanVienViewModel()
        {
            List = new ObservableCollection<Model.NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem==null)
                    return false;
                var displayList = DataProvider.Ins.DB.NHANVIENs.Where(x => x.TeNV == TeNV || x.CMND == CMND|| x.SDT == SDT|| x.MatKhau == MatKhau||x.GioiTinh==GioiTinh);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = new NHANVIEN() { TeNV = TeNV, CMND = CMND ,SDT = SDT,MatKhau = MatKhau ,GioiTinh = GioiTinh };
                DataProvider.Ins.DB.NHANVIENs.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.NHANVIENs.Where(x => x.TeNV == TeNV && x.CMND == CMND && x.SDT == SDT && x.MatKhau == MatKhau && x.GioiTinh == GioiTinh);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = DataProvider.Ins.DB.NHANVIENs.Where(x => x.MaNV == SelectedItem.MaNV).SingleOrDefault();
                dv.TeNV = TeNV;
                
                dv.CMND = CMND;
                dv.SDT = SDT;
                dv.MatKhau = MatKhau;
                dv.GioiTinh = GioiTinh;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.TeNV = TeNV;
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
               
                return true;
            }, (p) => {
                MessageBox.Show("Bạn có chắc xóa không?", "Nhắc nhở", MessageBoxButton.YesNo);
            });

        }

    }
}
