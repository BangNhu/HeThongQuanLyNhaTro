using QuanLyNhaTro_DACSN.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyNhaTro_DACSN.ViewModel
{   //Ke thua lai tu BaseViewModel
    public class MainViewModel:BaseViewModel
    {
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.NHANVIEN> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.NHANVIEN> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }
        }
        public ICommand QuenMatKhauCommand { get; set; }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand KhachTroCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand DienNuocCommand { get; set; }
        public ICommand DichVuCommand { get; set; }
        public ICommand HopDongCommand { get; set; }
        public ICommand HoaDonCommand { get; set; }
        public ICommand PhongTroCommand { get; set; }
        public ICommand NhanVienCommand { get; set; }
        public ICommand NhaTroCommand { get; set; }
        public bool Isloaded = false;
        public MainViewModel()
        {
            List = new ObservableCollection<Model.NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return  true; }, (p) => {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                Login login = new Login();
                login.ShowDialog();
                if (login.DataContext == null)
                    return;
                var loginVN = login.DataContext as LoginViewModel;
                if (loginVN.IsLogin)
                {
                    p.Show();
                }
                else
                {
                    p.Close();
                }
                
            });
            DienNuocCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                DienNuoc nv = new DienNuoc();
                nv.ShowDialog();

               
            });
            NhanVienCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {
                
                NhanVien nv = new NhanVien();
                nv.ShowDialog();
            });

            NhaTroCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                NhaTro nv = new NhaTro();
                nv.ShowDialog();
            });

            PhongTroCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                PhongTro nv = new PhongTro();
                nv.ShowDialog();
            });

            KhachTroCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                KhachTro nv = new KhachTro();
                nv.ShowDialog();
            });
            HopDongCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                HopDong nv = new HopDong();
                nv.ShowDialog();
            });
            HopDongCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                HopDong nv = new HopDong();
                nv.ShowDialog();
            });
            HoaDonCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                HoaDon nv = new HoaDon();
                nv.ShowDialog();
            });
            DichVuCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {

                DichVu nv = new DichVu();
                nv.ShowDialog();
            });
            LogoutCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {
                var b = this.LoadedWindowCommand;
                
            });
            QuenMatKhauCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => {
                MessageBox.Show("Hãy liên hệ với người quản lý", "Thông báo");

            });
        }
       
    }
}
