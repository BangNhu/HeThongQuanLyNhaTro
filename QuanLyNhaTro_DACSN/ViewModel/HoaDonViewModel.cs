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
    class HoaDonViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.Khutro> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.Khutro> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private Khutro _SelectedItem;
        public Khutro SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenKhuTro = SelectedItem.TenKhuTro;
                    DiaChi = SelectedItem.DiaChi;
                }

            }
        }
        private String _TenKhuTro;
        public String TenKhuTro { get => _TenKhuTro; set { _TenKhuTro = value; OnPropertyChanged(); } }
        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }


        public HoaDonViewModel()
        {
            List = new ObservableCollection<Model.Khutro>(DataProvider.Ins.DB.Khutroes);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenKhuTro) && string.IsNullOrEmpty(DiaChi))
                    return false;
                var displayList = DataProvider.Ins.DB.Khutroes.Where(x => x.TenKhuTro == TenKhuTro || x.DiaChi == DiaChi);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = new Khutro() { TenKhuTro = TenKhuTro, DiaChi = DiaChi };
                DataProvider.Ins.DB.Khutroes.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenKhuTro) && string.IsNullOrEmpty(DiaChi) || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.Khutroes.Where(x => x.TenKhuTro == TenKhuTro && x.DiaChi == DiaChi);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = DataProvider.Ins.DB.Khutroes.Where(x => x.MaKhuTro == SelectedItem.MaKhuTro).SingleOrDefault();
                dv.TenKhuTro = TenKhuTro;
                dv.DiaChi = DiaChi;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.TenKhuTro = TenKhuTro;
            });

        }

    }
}
