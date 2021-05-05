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
    class DienNuocViewModel : BaseViewModel
    {
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private ObservableCollection<QuanLyNhaTro_DACSN.Model.DienNuoc> _List;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.DienNuoc> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        private ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> _PHONG;
        public ObservableCollection<QuanLyNhaTro_DACSN.Model.PHONG> PHONG { get => _PHONG; set { _PHONG = value; OnPropertyChanged(); } }
        private QuanLyNhaTro_DACSN.Model.DienNuoc _SelectedItem;
        public QuanLyNhaTro_DACSN.Model.DienNuoc SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged();
                if (SelectedItem != null)
                {
                    NgayGhiDienNuoc = SelectedItem.NgayGhiDienNuoc;
                    GiaNuoc = SelectedItem.GiaNuoc;
                    GiaDien = SelectedItem.GiaDien;
                    ChiSoNuoc = SelectedItem.ChiSoNuoc;
                    ChiSoDien = SelectedItem.ChiSoDien;
                    SelectedPhong = SelectedItem.PHONG;
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
        private int _ChiSoDien;
        public int ChiSoDien { get => _ChiSoDien; set { _ChiSoDien = value; OnPropertyChanged(); } }
        private int _ChiSoNuoc;
        public int ChiSoNuoc { get => _ChiSoNuoc; set { _ChiSoNuoc = value; OnPropertyChanged(); } }
        private double _GiaDien;
        public double GiaDien { get => _GiaDien; set { _GiaDien = value; OnPropertyChanged(); } }
        private double _GiaNuoc;
        public double GiaNuoc { get => _GiaNuoc; set { _GiaNuoc = value; OnPropertyChanged(); } }
        private DateTime _NgayGhiDienNuoc;
        public DateTime NgayGhiDienNuoc { get => _NgayGhiDienNuoc; set { _NgayGhiDienNuoc = value; OnPropertyChanged(); } }

        public DienNuocViewModel()
        {
            List = new ObservableCollection<Model.DienNuoc>(DataProvider.Ins.DB.DienNuocs);
            PHONG = new ObservableCollection<Model.PHONG>(DataProvider.Ins.DB.PHONGs);

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.DienNuocs.Where(x => x.NgayGhiDienNuoc == NgayGhiDienNuoc || x.GiaNuoc == GiaNuoc || x.GiaDien == GiaDien || x.ChiSoNuoc == ChiSoNuoc || x.ChiSoDien == ChiSoDien);
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = new QuanLyNhaTro_DACSN.Model.DienNuoc() { NgayGhiDienNuoc = NgayGhiDienNuoc, GiaNuoc = GiaNuoc, GiaDien = GiaDien, ChiSoNuoc = ChiSoNuoc, ChiSoDien = ChiSoDien };
                DataProvider.Ins.DB.DienNuocs.Add(dv);
                DataProvider.Ins.DB.SaveChanges();
                List.Add(dv);
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;
                var displayList = DataProvider.Ins.DB.DienNuocs.Where(x => x.NgayGhiDienNuoc == NgayGhiDienNuoc && x.GiaNuoc == GiaNuoc && x.GiaDien == GiaDien && x.ChiSoNuoc == ChiSoNuoc && x.ChiSoDien == ChiSoDien );
                if (displayList == null || displayList.Count() != 0)
                    return false;
                return true;
            }, (p) => {
                var dv = DataProvider.Ins.DB.DienNuocs.Where(x =>  x.NgayGhiDienNuoc == NgayGhiDienNuoc|| x.MaPT==SelectedPhong.MaPhong).SingleOrDefault();
                dv.NgayGhiDienNuoc = NgayGhiDienNuoc;
                dv.GiaNuoc = GiaNuoc;
                dv.GiaDien = GiaDien;
                dv.ChiSoNuoc = ChiSoNuoc;
                dv.ChiSoDien = ChiSoDien;
                dv.MaPT = SelectedPhong.MaPhong;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.NgayGhiDienNuoc = NgayGhiDienNuoc;
            });

        }

    }
}