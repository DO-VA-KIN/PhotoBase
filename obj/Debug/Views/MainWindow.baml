   M S B A M L   `   `   `  ����D  @PhotoBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PhotoBase.ViewModelPhotoBase.ViewModel  5   	   1clr-namespace:PhotoBase.ViewsPhotoBase.Views  5	   	        PhotoBase.Views.MainWindow   5   	   0tk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   _ [MaterialDesignThemes.Wpf, Version=5.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0vm!clr-namespace:PhotoBase.ViewModel     5   	   /localclr-namespace:PhotoBase.Views     5	   	     � WindowStyle$
  None=�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$) #База пользователей��5   	   $��Regular"�5   	   $��14(�5   	   $	��450��5   	   $	��800��5   	    � Icon$ Icons/Monitor.Ico��5   	    � DataContext 5      &   PhotoBase.ViewModel.MainWindowVM  5   
   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
   .��5!      �    IsHitTestVisibleInChrome . 	 � RowDefinitions	 5"   
   �� 5#      $��35 �6   �� 5$      .+�5&   
   �� ._�5'      � .+�5(      �� 
 �� Orientation$
 
Horizontal=�6   $��RightToLeft=�62   .+�5)      m� 
������ $��2.5,2.5q�5*      $��50��5+       m� Command 5,      �� *AppShutDown+��5-      '  !MaterialDesignThemes.Wpf.PackIcon  5.      $��Center=�6&   $��Center=�5/   2   
�������   Kind$ WindowClose=�51   2   $��20��52   2   $��20��53   2   $	��-20q�54   2   56      m� 57      -   5        
������ $��50��58      $��0,2.5q�59      ��5;        5<      $��Center=�6&   $��Center=�5=   2   
�������$ WindowMaximize=�5?   2   $��20��5@   2   $��20��5A   2   $	��-20q�5B   2   5D      m� 5E      -   5        
������ $��0,2.5q�5F      $��50��5G      ��5I        5J      $��Center=�6&   $��Center=�5K   2   
�������$ WindowMinimize=�5M   2   $��20��5N   2   $��20��5O   2   $	��-20q�5P   2   5R      5S      �� 5T      $
 
Horizontal=�6   .+�5U        
�������$ DesktopWindows=�5V   *   $��30��5W   *   $��35��5X   *   $��5,5,10,0q�5Y   *   �� 5Z      $)��#База пользователей��6   $��Center=�69   5[      5\      5]      � 5_   
   $��1��6    � ColumnDefinitions 5`      �� 5a      $	��400��6#   �� 5b      $��5 �6#   �� 5c      $��2* �6#   �� 5d      $��5 �6#   �� 5e      $	��300��6#   .+�5h      #  MaterialDesignThemes.Wpf.Card  $��1��6   $��10q�6'   .��5i      � $��10q�6   	 5j      �� 5k      $��30 �6,   �� 5l      $��30 �6,   �� 5m      $��1* �6,   �� 5n      $��35 �6,   .+�5p      �� $��0��6%   .+�5q      �� $��Center=�6'    �� SelectedIndex$ 0��5r   #    �� IsTextSearchEnabled . $ �� IsSynchronizedWithCurrentItem$
 TrueY�5t   #    �� DisplayMemberPath$
 Name��5u   #    �� SelectedItem 5v   #   �� *CurrentUser+��5w   #   �� *Users+5y      �� 5z      $��1��6"   $��Center=�5{      ��5|      �� *CurrentUser.Summ+�� 5}      $��2��6"   
�����p�$��5q�5      $
 TrueY�5�      $
��Auto=�5�      $
��Auto=�5�      ��5�      �� *CurrentUser.PathPhotos+ 5�      �� *CurrentPhoto+�� 5�      $��Удалить��6!   $��4��5�   !   $��1��5�   !   $	��2.5q�5�   !   ��5�   !   �� *
DeleteUser+5�      5�      �� 5�      $��1��6   $��Stretch=�6+   $��Stretch=�6I   �� 5�      $��2��6   $��Stretch=�5�      $��Stretch=�5�      ��5�      �� *CurrentPhoto+�� 5�      $��3��6   $��Stretch=�6+   $��Stretch=�6I   �� 5�      $��4��6   .+�5�        $��0��6   $��10q�6(   .��5�      �� .+�5�      �� $��Center=�6"   $��7.5,5,7.5,0q�5�   "   ��5�   "   �� *	NewName+�� 5�      $��Добавить��6!   $��0��5�   !   $��10q�5�   !   ��5�   !   �� *	AddUser+5�      5�        5�      $��1��6   $��10q�6(   .��5�      �� .+�5�      �� $��Сохранить��6!   $��0��5�   !   $
��10,5q�5�   !   ��5�   !   �� *
SaveData+�� 5�      $��Загрузить��6!   $��0��5�   !   $
��10,5q�5�   !   ��5�   !   �� *
ReadData+�� 5�      $��Добавить Фото��6!   $��0��5�   !   $
��10,5q�5�   !   ��5�   !   �� *
AddPhoto+�� 5�      $��Удалить Фото��6!   $��0��5�   !   $
��10,5q�5�   !   ��5�   !   �� *DeletePhoto+5�      5�      5�      5�      5�      5�      