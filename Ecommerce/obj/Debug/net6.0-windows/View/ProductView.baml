   M S B A M L   `   `   `  ����K  GUserEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UserEcommerceApp.ViewUserEcommerceApp.View  5      G(clr-namespace:UserEcommerceApp.ViewModelUserEcommerceApp.ViewModel  5
      '    !UserEcommerceApp.View.ProductView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:UserEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      1vm(clr-namespace:UserEcommerceApp.ViewModel  5
      -   5        $��MyProductView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $��Center=�6    �� CornerRadius$ 10��5      $��	0 100 0 0q�6'   $	��1.6q�5      
���   �$	��550��5      $	��450��6!    �� Padding$ 5q�5      ���	#FF0E1646._�5      �� $ Vertical=�6   .+�5      ]� $	��200��6   .+�5      �� $	��180��6   $	��170��6)   $ 15��66   $	��1.6q�6H   
���������5      �� 5        �� ImageSource 6)   �� *image+5"      5#      �� 5$      $��Center=�6   $	��240��68   $��	25 0 25 0q�6E   .+�5%      ]� .+�5&      �� $
��Left=�6$   $��18(�6:   $
��Left=�6H   $��60��5'       $��30��6+   
�������$��Name: ��5)       �� 5*      $��Right=�6$   $��18(�6;   $��DemiBold"�6I   
�������$
��Left=�5+       $��30��5-       $	��400��6,   ��5,       �� *Product.Name+5-   ,   5.      �� 50      $��18(�6    
�������$
��Left=�51       $��Description:��52       $��20��53       $	��400��6,   �� 54      $
��Left=�6    $��14(�55       $
��Wrap=�6.   
�������$��80��57       $	��486��6,   ��56       �� *Product.Description+57   ,   ]� 58      .+�59      �� $
��Left=�6$   $��18(�6:   $
��Left=�6H   $��60��5:       $��30��6+   
�������$��Mark: ��5<       �� 5=      $��Right=�6$   $��18(�6;   $
��Left=�6I   $	��200��5>       $��30��6,   
���������5@       �� *Product.Make+5A      ]� 5C      .+�5D      �� $
��Left=�6$   $��18(�6:   $
��Left=�6H   $��90��5E       $��25��6+   
�������$��
Category: ��5G       �� 5H      $��Right=�6$   $	��150��6;   
�������$��18(�6Z   $��25��5I       $
��Left=�6,   ��5J       �� *Product.Category.Name+5K      ]� 5M      $��	250 0 0 0q�6    .+�5N      �� $
��Left=�6$   $��20(�6:   $
��Left=�6H   $��70��5O       $��28��6+   
�������$��Price: ��5Q       �� 5R      $��Right=�6$   $	��175��6;   
�������$��18(�6Z   $��28��5S       $
��Left=�6,   ��5T       �� *Product.Price+5U      5V      5W      5X      � 5Y   
   $
��20 0q�6    � ColumnDefinitions 5Z      �� 5[      $
��0.3* �6#   �� 5\      $
��0.6* �6#   �� 5]      $
��0.3* �6#   �� 5^      .+�5a      �� $��0��6   $��50��6%   $��90��61   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5b   !   ���	#FF4E93FF$��Center=�5d   !   ���	#FF4E93FF��5c   !   �� *BackToShopCommand+.��5e      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6   
�������$	��100��5g   &   $��50��62   $��Center=�6>   $��Center=�6Y   	 J� Effect	 5h      3  -System.Windows.Media.Effects.DropShadowEffect  5i      
   
BlurRadius$
 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]      Color$ Black��6m   5k      � 5m      $��1��6   $��20 10q�6#    5o      �� 5p      $
��0.7* �6'   �� 5q      �� 5r      $
��0.7* �6'   .+�5v      �� $��0��6   $��50��5w   G   $ 15��5x      ���	#FF0E1646���	#FF0E1646��5v   )   �� *DownQuantityCommand+{�5w      �� *IsEnabledToQuantityDown+.��5y        $ 	ArrowBack=�6"   
�������$��25��5z   &   $��30��61   $��Center=�6=   $��Center=�6X   	 5{        5|      $
 15Q�6+   $ 0Q�6;   $ Quality=�6I   $ 1Q�6a   $ Black��6q   5~      �� 5�      $��1��6   $ 15��6)   $��40��6;   $��60��6G   ��5�      �� 5�       �� Color$ 	#FFBBBBBB��6*   ._�5�      ��  �� TextAlignment$ Center=�6J   $��10q�5�       $��Center=�6,   $��Center=�6I   $��28(�6d   ��5�       �� *
Quantity+ �� FallbackValue$ 1��5�   d   	 5�        5�      $
 15Q�6+   $ 0Q�6;   $ Quality=�6I   $ 1Q�6a   $ Black��6q   5�      �� 5�      $��2��6   $ 15��6O   ���	#FF0E1646���	#FF0E1646��6)   �� *UpQuantityCommand+.��5�        $ ArrowForward=�6"   
�������$��25��5�   &   $��30��61   $��Center=�6=   $��Center=�6X   	 5�        5�      $
 15Q�6+   $ 0Q�6;   $ Quality=�6I   $ 1Q�6a   $ Black��6q   5�      5�      �� 5�      $��2��6   $��75��6%   $��80��61   $ 45��5�   !   ���	#FFFBA02B$��Center=�5�   !   ���	#FFFBA02B��5�   !   �� *AddToBasketCommand+.��5�        $ ShoppingBasketPlus=�6   
�������$	��100��5�   &   $��50��62   $��Center=�6>   $��Center=�6Y   	 5�        5�      $
 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5�      �� 5�      $��3��6   $ 15��6%   $��20q�5�      $	��300��6   $��50��6)   $��Buy Product��65   $��26(�6K   $��Center=�5�      ���	#FF05AF00
����������	#FF05AF00��5�      �� *BuyProductCommand+	 5�        5�      $
 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5�      5�      5�      5�      