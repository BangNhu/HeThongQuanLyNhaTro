   M S B A M L   `   `   `  ����M  IQuanLyNhaTro_DACSN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:QuanLyNhaTro_DACSNQuanLyNhaTro_DACSN  5   	   S.clr-namespace:QuanLyNhaTro_DACSN.UserControlBN QuanLyNhaTro_DACSN.UserControlBN  5
   	   '    !QuanLyNhaTro_DACSN.DanhSachHoaDon   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:QuanLyNhaTro_DACSN     5   	   =uc.clr-namespace:QuanLyNhaTro_DACSN.UserControlBN     5
   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��nHopDong��5	   	     � Title$  Hợp đồng��5   	   $	��550��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       
 MainVM � DataContext# [ 5       � 
ResizeMode$ NoResize=�5       � WindowStyle$
 None=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6    � ColumnDefinitions 5    
   �� 5!      $
��auto �6   6.   �� 5"      6"   .+�5$   
   � $��0��6   $��2��6   .+�5%      1   +QuanLyNhaTro_DACSN.UserControlBN.UserMenuUC  6   5&      � 5'   
   $��0��6   $��1��6   .+�5(      0   *QuanLyNhaTro_DACSN.UserControlBN.UserBarUC  
	 � Tag	 6   �� *Title+
 �� ElementName$
 nNhaTro��6H   5)      � 5*   
   $��1��6   $��1��6   .+�5,      #  MaterialDesignThemes.Wpf.Card  $��2��6"   $��5q�6/   $��Stretch=�6:   .��5.      �� $
��Auto=�6   .��50      �� ��6   �� *List+ �� SelectedItem 6<   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 51      �� 52      .P�53   "   �� $��	Khu trọ��61    �� DisplayMemberBinding 6B   �� *
TenPhong+6n   �� 54   "   $��Tên Phòng��61    6E   �� *TenKT+6n   �� 55   "   $��Tiền điện��61    6E   �� *
NgayBatDau+6s   �� 56   "   $��Tiền nước��61    6E   �� *NgayKetThuc+6t   �� 57   "   $��Tiền dịch vụ��61    6H   �� *DonGia+6r   �� 58   "   $��Tổng cộng��61    6E   �� *DonGia+6o   59      5;      5<      5=      5?      5@      5A      