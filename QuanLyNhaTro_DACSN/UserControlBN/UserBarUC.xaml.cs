using QuanLyNhaTro_DACSN.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyNhaTro_DACSN.UserControlBN
{
    /// <summary>
    /// Interaction logic for UserBarUC.xaml
    /// </summary>
    public partial class UserBarUC : UserControl
    {
        public ControlBarViewModel Viewmodel { get; set; }
        public UserBarUC()
        {
            InitializeComponent();
            this.DataContext = Viewmodel = new ControlBarViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
