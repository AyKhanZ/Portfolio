   M S B A M L   `   `   `  ����K  GUserEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UserEcommerceApp.ViewUserEcommerceApp.View  5      G(clr-namespace:UserEcommerceApp.ViewModelUserEcommerceApp.ViewModel  5
      &     UserEcommerceApp.View.BasketView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:UserEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      1vm(clr-namespace:UserEcommerceApp.ViewModel  5
      -   5        $��MyBasketView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � RowDefinitions 5      �� 5      $��0.07* �6    �� 5      .+�5      � $��1��6    5!      �� 5"      $��3* �6$   �� 5#      $
��0.7* �6$   .+�5&      �� $��0��6   $	��750��6'   $	��450��63   $ 10��6@   $��Center=�6R   ���	#FF0E1646$��Center=�5'   0    J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         
BlurRadius$ 15Q�6+      	Direction$ 0Q�6;      RenderingBias$ Quality=�6I      ShadowDepth$ 1Q�6a   	   Color$	 Black��6q   ._�5,      � $	��400��6   $	��650��6)   $��Center=�65   .+�5.      �� $��25q�6!   $��0��6-   ���	#FF4E93FF$ 25��6Q   ._�50      �� $��25q�6,   .��51   "   �� $
��True��54   )   $��Disabled=�55   )   
������ ��52   )   �� *SearchResults+
 �� SelectedItem
 53   )   �� *SelectedBasketProduct+��57   &   �� 58   *   .R�59   .   �� $��Center=�65   $ 10��6R   $��1q�5:   5   
�������$	��450��5;   5   $	��350��6A    �� Padding$ 5q�5<   5   ���#22202f._�5=   2   ��  �� Orientation$ Vertical=�6=   .+�5>   6   ]� $	��210��6@   .+�5?   :   �� $	��200��6A   $	��300��6N   $ 3 0 3 0q�5@   9   $ 10��5A   9   $	��1.6q�5B   9   
���������5C   >   �� 5D   B    j� Stretch$
 Fill=�6M    �� ImageSource 6\   �� *Product.Image+ �� UpdateSourceTrigger$ PropertyChanged=�5F   ;   5G   7   �� 5H   6   $��Center=�6A   $	��0 9q�6\   .+�5I   :   �� $��16(�6D   $��DemiBold"�6R   $��Center=�6h   
���������6�   �� *Product.Name+$ PropertyChanged=��� 5J   :   $��Center=�6D   $
��Wrap=�6a   
���������6�   �� *Product.Description+$ PropertyChanged=��� 5K   :   $��20(�6D   $
��Left=�6R   $��20 0 0 0q�6m    �� TextAlignment$
 Left=�6   $��90��6�   
���������6�   �� *Product.Price+$ PropertyChanged=� �� StringFormat$
 {0}$��5L   7   5M   3   5N   /   5O   +   ��5Q   &   �� 5R   *   .R�5S   .   � 5T   +   5V   #   5W      5X      5Y      5Z      � 5\      $��1��6    � ColumnDefinitions 5]      �� 5^      $
��0.5* �6+   �� 5_      $
��0.5* �6+   �� 5`      .+�5e      �� $��0��6   $��50��6-   $��90��69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5f   !   ���	#FF4E93FF$��Center=�5h   !   ���	#FF4E93FF��5g   !   �� *BackToHomeCommand+.��5i      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6&   
�������$	��100��6J   $��60��6V   $��Center=�6b   $��Center=�6}    5j        5k      $ 15Q�6/   $ 0Q�6?   $ Quality=�6M   $ 1Q�6e   $	 Black��6u   5m      �� 5q      $��1��6   $ 15��6U   $��50��6w   $	��150��6�   
���  ��{�6-   �� *IsEnabledToCancel+��5r   -   �� *DeleteProductCommand+.��5s        $ Cancel=�6&   $��40��66   $��40��6B   
�������6M   ��5u      �� 5v       �� Color$ 	#FFA20000��6.    5y        5z      $ 15Q�6/   $ 0Q�6?   $ Quality=�6M   $ 1Q�6e   $	 Black��6u   5|      �� 5~      $��2��6   ���	#FF4E93FF$ 10��6E   $��60��6W   $	��400��6c   ._�5      �  5�      �� 5�   "   �� 5�   "   $
��0.2* �63   .+�5�      �� $��0��6&   $��40��66   $��	20 0 10 0q�5�   -   $��22(�6@   ���	#FF4E93FF
���   �
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search product by name��5�   -   ��5�   N   �� *
SearchText+5�   -   �� 5�      $��1��6%   $��50��65   $��50��6@   $ 15��6M   $��2,2,2,2q�5�   Z   ���	#FF2C6AFF��61   �� *SearchProductCommand+��5�   "   �� 5�   &   $ 	#FF2C6AFF��66   .��5�   "     $ Search=�6.   $��45��6<   $��45��6G   
�������6S    5�   "     5�   &   $ 15Q�67   $ 0Q�6G   $ Quality=�6U   $ 1Q�6m   $	 Black��6}   5�      5�      5�      5�      5�      5�      5�      5�      