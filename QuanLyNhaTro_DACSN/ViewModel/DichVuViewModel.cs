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
using System.ComponentModel;
using System.Windows.Data;

namespace QuanLyNhaTro_DACSN.ViewModel
{
    public class DichVuViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> _SD_DichVu;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.SD_DichVu> SD_DichVu { get => _SD_DichVu; set { _SD_DichVu = value; OnPropertyChanged(); } }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.DICHVU> List { get=> _List; set { _List = value; OnPropertyChanged(); } }
        private DICHVU _SelectedItem;
        public DICHVU SelectedItem { get=> _SelectedItem; set { _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    TenDV = SelectedItem.TenDV;
                    DonGia = SelectedItem.DonGia;
                } 
                   
            } }
        private String _TenDV;
        public String TenDV { get => _TenDV; set { _TenDV = value; OnPropertyChanged(); } }
        private double _DonGia;
        public double DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }


        public DichVuViewModel()
        {
            List = new ObservableCollection<Model.DICHVU>(DataProvider.Ins.DB.DICHVUs);

            AddCommand = new RelayCommand<object>((p) =>
           {
               if (string.IsNullOrEmpty(TenDV) || DonGia < 1)
                   return false;
               var displayList = DataProvider.Ins.DB.DICHVUs.Where(x => x.TenDV == TenDV);
               if (displayList == null || displayList.Count() != 0)
                   return false;
               return true;
           }, (p) => {
               var dv = new DICHVU() { TenDV = TenDV, DonGia = DonGia };
               DataProvider.Ins.DB.DICHVUs.Add(dv);
               DataProvider.Ins.DB.SaveChanges();
               List.Add(dv);
           });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(TenDV) || DonGia < 1 || SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.DICHVUs.Where(x => x.TenDV == TenDV && x.DonGia == DonGia);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = DataProvider.Ins.DB.DICHVUs.Where(x => x.MaDV == SelectedItem.MaDV).SingleOrDefault();
                dv.TenDV = TenDV;
                dv.DonGia = DonGia;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.TenDV = TenDV;
            });
            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.DICHVUs.Where(x => x.MaDV == SelectedItem.MaDV);
                if (displayList != null || displayList.Count() != 0)
                    return true;
                return false;
            }, (p) => {
            var t = MessageBox.Show("Bạn có chắc xóa?", "Nhắc nhở", MessageBoxButton.YesNo);
                if (t == MessageBoxResult.Yes)
                {
                    var dv = DataProvider.Ins.DB.DICHVUs.Where(x => x.MaDV == SelectedItem.MaDV).SingleOrDefault();
                    DataProvider.Ins.DB.DICHVUs.Remove(dv);
                    DataProvider.Ins.DB.SaveChanges();
                    List.Remove(dv);
                }
            });
       
        }

    }
}
