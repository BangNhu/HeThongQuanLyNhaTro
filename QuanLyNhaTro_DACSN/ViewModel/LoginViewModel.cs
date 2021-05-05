using QuanLyNhaTro_DACSN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyNhaTro_DACSN.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        static int h = 0;
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public bool IsLogin { get; set; }
        public LoginViewModel()
        {
            IsLogin = false;
            LoginCommand = new RelayCommand<Window>((p) => {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(UserName))
                    return false;
                else
                    return true;
            }, (p)=>{ Login(p); });
            LogoutCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password;});


            void Login(Window p)
            {
                if (p == null)
                    return;
                var a = DataProvider.Ins.DB.CHUTROes.Where(x => x.SDT == UserName && x.MatKhau == Password).Count();
                var b = DataProvider.Ins.DB.NHANVIENs.Where(x => x.SDT == UserName && x.MatKhau == Password).Count();
                var c = DataProvider.Ins.DB.KhachTroes.Where(x => x.SDT == UserName && x.MatKhau == Password).Count();
                if (a + b + c > 0)
                {
                    IsLogin = true;
                    p.Close();
                }    
                
                else
                {
                    h++;
                    IsLogin = false;
                   MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
                }
                if (h > 3)
                    MessageBox.Show("Nếu quên mật khẩu hãy liên hệ với người quản lý!", "Thông báo");
                
            }

           


        }

    }
}
