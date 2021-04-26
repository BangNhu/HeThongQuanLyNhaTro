﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyNhaTro_DACSN.ViewModel
{
    public class ControlBarViewModel:BaseViewModel
    {
        #region
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseMoveWindowCommand { get; set; }
        #endregion
        public ControlBarViewModel()
        {
           CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if(w != null)
                {
                    w.Close();
                }
            });

            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if(w.WindowState != WindowState.Maximized)
                        w.WindowState = WindowState.Maximized;
                    else
                        w.WindowState = WindowState.Normal;
                }
            });

            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Minimized)
                        w.WindowState = WindowState.Minimized;
                    else
                        w.WindowState = WindowState.Normal;
                }
            });
            //keo di chuyen form tuy y
            MouseMoveWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.DragMove();
                }
            });
        }
        //Lay thang window cuoi cung
        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;
            
            while (parent.Parent != null)
            {    
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
           
    }
}