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
    /// Interaction logic for UserMenuUC.xaml
    /// </summary>
    public partial class UserMenuUC : UserControl
    {
        public UserMenuUC()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            Info.Visibility = Visibility.Visible;
            scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            Info.Visibility = Visibility.Collapsed;
        }
    }
}
