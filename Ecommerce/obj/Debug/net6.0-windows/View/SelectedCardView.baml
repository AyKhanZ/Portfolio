   M S B A M L   `   `   `  ����K  GUserEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UserEcommerceApp.ViewUserEcommerceApp.View  5      G(clr-namespace:UserEcommerceApp.ViewModelUserEcommerceApp.ViewModel  5
      ,    &UserEcommerceApp.View.SelectedCardView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:UserEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      1vm(clr-namespace:UserEcommerceApp.ViewModel  5
         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � RowDefinitions 5      �� 5      $��5 �6    �� 5      $��0.07* �6    �� 5      $
��0.8* �6    �� 5      $
��0.2* �6    .+�5      �� $��1��6   $��80��6%   $��15��60   $
��Left=�6<   $��Center=�6W   $��	 MY CARDS��5       
�������$��14(�68   $��10,0,0,0q�6F   �� 5$      $��2��6   $	��800��6"   $	��450��6.   $ 10��6;   $��Center=�6M   ���	#FF0E1646$��Center=�5%   ,    J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   	   Color$	 Black��6m   ._�5*      � $	��400��6   $	��800��6$   $��Center=�60   $��15q�6M   .+�5,      �� ���	#FF4E93FF$ 25��5-      $��50 20q�6/   ._�5/      �� $
��True��51   "   $��Disabled=�52   "   ���	#FF4E93FF���	#FF0E1646��5/   #   �� *Cards+
 �� SelectedItem
 50   "   �� *SelectedCard+��54      �� 55   "   .R�56   &   �� $��2��6-   $	��165��6:   $	��290��6G   $ 10��6S   $��Center=�6e   ���	#FF0E1646$��Center=�57   D   $
��15 0q�6a    58   *     59   .   $ 15Q�6?   $ 0Q�6O   $ Quality=�6]   $ 1Q�6u   $	 Black��6�   ._�5<   *   � $	��130��6/   $	��270��6<   $��Center=�6H    5=   .   �� 5>   2   $
��0.5* �6@   �� 5?   2   $
��1.5* �6@   �� 5A   2   $
��2.6* �6@   .+�5D   .   �� $��0��68   $��16 digit code:��6E   $
��Left=�6[   $��Bottom=�6v   
�������$��14(�5E   K   $��5 0 0 0q�6Y   �� 5F   .   $��1��68   
�������
������ $��15��5G   =   $	��150��6I   $
��Left=�6U   $��14(�6p   $��10 0 0 0q�6~   $��Center=�5H   _   ��6=   �� *SixteenDigitCode+6_   � 5J   .   $��2��63    5L   2   �� 5M   6   $
��0.7* �6D   �� 5N   6   $��1* �6D    � ColumnDefinitions 5Q   2   �� 5R   6   �� 5S   6   .+�5V   2   �� $��0��6<   $��0��6I   $
��EXP:��6Y   $
��Left=�5W   =   $��Bottom=�6X   
�������$��14(�5X   P   $��10 0 0 0q�6^   �� 5Z   2   $��1��6<   $��0��6I   
�������
������ $��15��5[   =   $��50��6I   $
��Left=�6T   $��14(�6o   $��10 0 0 0q�6}   $��Center=�5\   R   ��6=   �� *EXP+6R   �� 5_   2   $��1��6<   $��0��6L   $
��CVV:��6Y   $
��Left=�5`   =   $��Bottom=�6X   
�������$��14(�5a   P   $��10 0 0 0q�6^   �� 5b   2   $��1��6<   $��1��6L   $��14(�6Y   $��10 0 0 0q�6g   
�������
������ $��15��5d   =   $��50��6I   $
��Left=�6T   $��Center=�5e   R   ��6=   �� *CVV+6R   5f   /   5g   +   5h   '   5i   #   ��5k      �� 5l   "   .R�5m   &   � 5n   #   5p      5q      5r      5s      � 5w      $��3��6    5y      �� 5z      �� 5{      .+�5�      �� $��0��6   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��6)   $��50��6K   $	��150��6W   ���	#FF2C6AFF��5�   )   �� *BackToProductCommand+.��5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6"   $��50��65   $��50��6A   
�������$��Center=�6_   $��Center=�6|   ��5�      �� 5�       �� Color$ 	#FF2C6AFF��6*    5�        5�      $ 15Q�6+   $ 0Q�6;   $ Quality=�6I   $ 1Q�6a   $	 Black��6q   5�      �� 5�      $��1��6   $ 15��6O   $��70��6q   $	��250��6}   
��� � �{�6)   �� *IsEnabledForPay+��5�   )   �� *PayByCardCommand+.��5�        $ Payment=�6"   $��60��63   $��60��6?   
�������6J   ��5�      �� 5�      $ Green��6*    5�        5�      $ 15Q�6+   $ 0Q�6;   $ Quality=�6I   $ 1Q�6a   $	 Black��6q   5�      5�      5�      5�      5�      