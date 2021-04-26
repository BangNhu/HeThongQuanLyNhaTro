using System;
using System.Collections.Generic;
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
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand KhachTroCommand { get; set; }
        public ICommand DichVuCommand { get; set; }
        public ICommand HopDongCommand { get; set; }
        public ICommand HoaDonCommand { get; set; }
        public ICommand PhongTroCommand { get; set; }
        public ICommand NhanVienCommand { get; set; }
        public ICommand NhaTroCommand { get; set; }
        public bool Isloaded = false;
        public MainViewModel()
        {
            Login lg = new Login();
            lg.ShowDialog();

            LoadedWindowCommand = new RelayCommand<UserControl>((p) => { return  true; }, (p) => {
                Isloaded = true;
                Login login = new Login();
                login.ShowDialog();
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
        }
       
    }
}
