   M S B A M L   `   `   `  ����M  IQuanLyNhaTro_DACSN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:QuanLyNhaTro_DACSN.UserControlBN QuanLyNhaTro_DACSN.UserControlBN  5      1    +QuanLyNhaTro_DACSN.UserControlBN.UserMenuUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:QuanLyNhaTro_DACSN.UserControlBN     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	       
  MainVM  � DataContext#  [  5       � 	Resources 5        MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[ 6   6G   5      :� 5   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5      �� #��[ 6   6H   5      .��5!      � .+�5"   
   � -   5        	 �Name$	 GridMenu��5"      $��60��6!   $
��Left=�6,   ���	#FFE7DFF0.+�5#      �� -   5        
 ��Name$
 scroll��5#   @   $��Hidden=�6   .��5$      �� .+�5%      � $��60��6   $	��Top=�6'   .+�5&      �� -   5         ��Name$ ButtonCloseMenu��5&   S     MaterialDesignIconButton#��[ 6!   $��0q�6�   $��60��6�   $��60��6�   $��Right=�6�   $y�	Collapsed=�6�   ��6l   Z� ��6�   Z� .��5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�66   $��35��6G   $��35��6R   6`   5(      �� 5)      -   5        $ ButtonOpenMenu��5)   S   #��[ 6!   $��0q�6�   $��60��6�   $��60��6�   $��Right=�6�   ��6k   Z� ��6�   Z� .��5*        $
 Menu=�66   $��35��6B   $��35��6M   6[   5+      5,      � 5-      -   5        $
	 Info��5-      $y�	Collapsed=�6)   .+�5.      &   MaterialDesignThemes.Wpf.Flipper  +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5/         FrontContent 50      � 51   "   $	��220��52      $	��190��53       � RowDefinitions 54   &   �� 55   *   $	��160 �56      �� 57   *   $��* �58      .+�5:   &   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�5;   	   $��Stretch=�5<   	   .��5=   *     $ AccountCircle=�5>      $	��128��5?      $	��128��5@      $��Center=�5A      $��Center=�5B      5C   '   �� 5D   &   $��1��5E   	   $��Center=�5F   	   $��Center=�5G   	   .+�5H   *   �� $��Trần Khánh Như��5I      �� 5J   *     MaterialDesignFlatButton#��[ 5K         FlipCommand#��Z 5L      $��0 4 0 0q�5M      $��
Thông tin��5N      5O   '   5P   #      BackContent 5R      � 5S   "   $	��220��5T      $	��190��5U       5V   &   �� 5W   *   $
��Auto �5X      �� 5Y   *   $��* �5Z      .+�5\   &     $ SecondaryMid=�5]   	   $��6q�5^   	   .��5_   *   ��  �� Orientation$ 
Horizontal=�5`      .+�5a   .   ��  & "MaterialDesignToolForegroundButton#��[ 5b      #��Z 5c      $
��Left=�5d      .��5e   2     $ 	ArrowLeft=�5f      $��Right=�5g      5h   /   �� 5i   .   $��8 0 0 0q�5j      $��Center=�5k      $��	EDIT USER��5l      5m   +   5n   '   � 5o   &   $��1��5p   	   $��0 6 0 0q�5q   	   $��Center=�5r   	   $	��Top=�5s   	   $	��172��5t   	    5u   *   �� 5v   .   �� 5w   .   �� 5x   .   �� 5y   .   .+�5{   *   �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
First name��5|         
IsFloating . $��0 12 0 0q�5~      $��James��5      �� 5�   *   $��1��5�      $ 	Last name��5�       . $��0 12 0 0q�5�      $��Willock��5�      �� 5�   *   $��2��5�      $ 
Horizontal=�5�      $��0 12 0 0q�5�      $��Right=�5�      .+�5�   .   �� $��Center=�5�      $��Email Contact��5�      d� 5�   .   $��8 0 0 0q�5�      5�   +   �� 5�   *   $��3��5�      $ 
Horizontal=�5�      $��0 12 0 0q�5�      $��Right=�5�      .+�5�   .   �� $��Center=�5�      $��Telephone Contact��5�      d� 5�   .   $��8 0 0 0q�5�      5�   +   5�   '   5�   #   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6K   �� *NhaTroCommand+.��5�      �� $ 
Horizontal=�6%    � ToolTip$ 
Nhà trọ��6>   .+�5�        $ 	HomeGroup=�66   $��25��6G   $��25��6R   $��	0 0 15 0 q�6^   6s   �� 5�      $��Center=�6(   
Nhà trọ6L   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6K   �� *PhongTroCommand+.��5�      �� $ 
Horizontal=�6%   $ Phòng trọ��6>   .+�5�        $ HomeCircleOutline=�66   $��25��6O   $��25��6Z   $��	0 0 15 0 q�6f   6{   �� 5�      $��Center=�6(   Phòng trọ6N   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *HopDongCommand+.��5�      �� $ 
Horizontal=�6%   $ Hợp đồng��6>   .+�5�        $ NewspaperVariantOutline=�66   $��25��6U   $��25��6`   $��	0 0 15 0 q�6l   6�   �� 5�      $��Center=�6(   Hợp đồng6M   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *HoaDonCommand+.��5�      �� $ 
Horizontal=�6%   $ 
Hóa đơn��6>   .+�5�        $ 	Newspaper=�66   $��25��6G   $��25��6R   $��	0 0 15 0 q�6^   6s   �� 5�      $��Center=�6(   
Hóa đơn6L   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *HoaDonCommand+.��5�      �� $ 
Horizontal=�6%   $ Dịch vụ��6>   .+�5�        $ Ballot=�66   $��25��6D   $��25��6O   $��	0 0 15 0 q�6[   6p   �� 5�      $��Center=�6(   Dịch Vụ6L   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *DienNuocCommand+.��5�      �� $ 
Horizontal=�6%   $ Điện nước��6>   .+�5�        $ Flash=�66   $��25��6C   $��25��6N   $��	0 0 15 0 q�6Z   6o   �� 5�      $��Center=�6(   Điện nước6N   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *PhanQuyenCommand+.��5�      �� $ 
Horizontal=�6%   $ Nhân viên��6>   .+�5�        $ AlertOctagon=�66   $��25��6J   $��25��6U   $��	0 0 15 0 q�6a   6v   �� 5�      $��Center=�6(   Phân quyền6O   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6L   �� *KhachTroCommand+.��5�      �� $ 
Horizontal=�6%   $ Khách trọ��6>   .+�5�        $ AccountGroupOutline=�66   $��25��6Q   $��25��6\   $��	0 0 15 0 q�6h   6}   �� 5�      $��Center=�6(   Khách trọ6N   5�      5�      �� 5�      $��45��6   $
��Left=�6)   ��6K   �� *NhanVienCommand+.��5�      �� $ 
Horizontal=�6%   $ Nhân viên��6>   .+�5�        $ AccountGroup=�66   $��25��6J   $��25��6U   $��	0 0 15 0 q�6a   6v   �� 5�      $��Center=�6(   Nhân viên6N   5�      5�      �� 5�      $��0 30 0 0q�6   $��45��6/   $
��Left=�6;   ��6]   �� *DangXuatCommand+.��5�      �� $ 
Horizontal=�6%   $ Đăng xuất��6>   .+�5�        $ Logout=�66   $��25��6D   $��25��6O   $��	0 0 15 0 q�6[   6p   �� 5�      $��Center=�6(   Đăng xuất6N   5�      5�      5�      5�      5�      5�      5�      